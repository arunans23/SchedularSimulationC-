
import java.io.BufferedReader;
import java.io.FileReader;
import java.util.List;
import java.util.ArrayList;
import java.util.LinkedList;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Sivakar
 */
public class Scheduler {
    static final int MAX_BURST_TIME = 20;
    static final int MAX_ARRIVAL_TIME = 100;

    static final String FILENAME = "processes.csv";

    private LinkedList<Process> readyQueue;
    private ArrayList<Process> blockedList;
    private List<Process> allProcess;
    private ArrayList<Process> finishedProcesses;
    private Process currentProcess;

    private int timeQuantum;
    private int timeUntilPreemption;
    private int currentTime;
	
	private int idleTime;
	private int serviceTime;

    public Scheduler()
    {
        timeQuantum = 10;   // use setTimeQuantum to change
        currentTime = 0;
        readyQueue = new LinkedList<Process>();
        blockedList = new ArrayList<Process>();
        allProcess = new ArrayList<Process>();
        finishedProcesses = new ArrayList<Process>();
    }
    public void setTimeQuantum(int time)
    {
        this.timeQuantum = time;
    }

    // Random generation is what we are going to use for now
//    public void createRandomProcesses(int n)
//    {
//        Random random = new Random();
//        for (int i = 0; i < n; i++)
//        {
//            Process p = new Process(random.nextInt(MAX_ARRIVAL_TIME) + 1,
//                    random.nextInt(MAX_BURST_TIME) + 1);
//            allProcess.add(p);
//        }
//    }
    // When process are added from the GUI or from file
    public void addProcess(Process p)
    {
        allProcess.add(p);
    }

    // increment the executing time of current process
    // increment the waiting time of all ready processes
    // increment the blocked time of all the process in the blocked list
    // if a process is finished, mark finish, dequeue a new process,
    //      and reset the time
    // if current process needs to be blocked, send to the blocked list
    //      and dequeue a new process
    // if it its time to preempt, dequeue a new process,
    //      and enqueue the current one, and reset the preempt time
    // if a new process can come in, add it to the queue
    // if a blocked process can resume, add it to the queue
    public void nextClockCycle()
    {
        currentTime++;
        for(Process p : allProcess)
        {
            if (p.getArrivalTime() == currentTime)
            {
                p.setArrived(true);
                readyQueue.add(p);
                p.setReady(true);
            }
        }
        if (currentProcess == null) {
            currentProcess = readyQueue.poll();
            if (currentProcess != null) {
                currentProcess.setActive(true);
                currentProcess.setReady(false);
                timeUntilPreemption = timeQuantum;
            } else {
				idleTime++;
			}
        }
        if (currentProcess != null) {
            currentProcess.incrementExecutedTime();
            timeUntilPreemption--;
        }
        for(Process p : readyQueue)
        {
            p.incrementWaitingTime();
        }
        for (Process p: blockedList) {
            p.incrementBlockedTime();
        }
        if (currentProcess != null && processFinished(currentProcess)) {
            currentProcess.setFinished(true);
            currentProcess.setActive(false);
            currentProcess.setReady(false);
            finishedProcesses.add(currentProcess);
            currentProcess = null;
        }
        if (currentProcess != null &&
                currentProcess.isTimeToBlock()) {
            currentProcess.setActive(false);
            currentProcess.setBlocked(true);
            blockedList.add(currentProcess);
            currentProcess = null;
        }
        if (currentProcess != null && timeUntilPreemption == 0) {
            currentProcess.setActive(false);
            currentProcess.setReady(true);
            readyQueue.add(currentProcess);
            currentProcess = null;
        }
        for (Process p : allProcess) {
            if (p.isTimeToUnblock()) {
                p.setBlocked(false);
                p.setReady(true);
                blockedList.remove(p);
                readyQueue.add(p);
            }
			if (p.getBlocked() && processFinished(p)) {
				p.setBlocked(false);
				p.setFinished(true);
				blockedList.remove(p);
				finishedProcesses.add(p);
			}
        }


    }
    private boolean processFinished(Process process)
    {
        return process.getExecutedTime() + process.getBlockedTime() ==
                process.getTotalTime();
    }
	public boolean allProcessFinished() {
		for (Process p : allProcess) {
			if (!p.isFinished()) {
				return false;
			}
		}
		return true;
	}
    public void loadProcesesDataFromFile() {
        try {
            BufferedReader reader = new BufferedReader(new FileReader(FILENAME));

            String line;
            Process p;
            while((line = reader.readLine()) != null) {
                String[] tokens = line.split(",");
                int[] ints = new int[tokens.length];
                for (int i = 0; i < tokens.length; i++) {
                    ints[i] = Integer.parseInt(tokens[i]);
                }
                p = new Process(ints);
                addProcess(p);
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public LinkedList<Process> getReadyQueue() { return readyQueue; }
    public ArrayList<Process> getBlockedItems() { return blockedList; }
    public ArrayList<Process> getFinishedItems() { return finishedProcesses; }
	public List<Process> getAllProcess() { return allProcess; }
    public Process getCurrentProcess() { return currentProcess; }
	
	public int getCurrentTime() { return currentTime; }
	public int getIdleTime() { return idleTime; }
	public int getTimeUntilPreemption() { return timeUntilPreemption; }
	public int getTimeQuantum() { return timeQuantum; }
	
}
