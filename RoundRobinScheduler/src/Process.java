
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
public class Process {
	private int processId;

    private int arrivalTime;
    private int burstTime;
    private int executedTime;
    private int waitingTime;
    private int blockedTime;
    private int totalTime;

    private LinkedList<Integer> blockingTimes;
    private LinkedList<Integer> unblockingTimes;

    private boolean arrived;
    private boolean active;
    private boolean ready;
    private boolean blocked;
    private boolean finished;

    private static int createdProcesses = 0;

    public Process(int[] times)
    {
        processId = createdProcesses;
        createdProcesses++;

        blockingTimes = new LinkedList<Integer>();
        unblockingTimes = new LinkedList<Integer>();
        processTimesArray(times);

        this.arrived = false;
        this.ready = false;
        this.active = false;
        this.finished = false;
    }

    public void processTimesArray(int[] times) {
        this.arrivalTime = times[0];
        int lastTime = 0;
        for (int i = 1; i < times.length - 1; i++) {
            if (i % 2 == 1) {
                blockingTimes.add(times[i] + lastTime);
            } else {
                unblockingTimes.add(times[i] + lastTime);
            }
            totalTime += times[i];
            lastTime += times[i];
        }
        totalTime += times[times.length - 1];
    }
    // remove time from list if it is returned true
    // so we can always check only the first element
    public boolean isTimeToBlock() {
        if (!blockingTimes.isEmpty()
                &&(executedTime + blockedTime == blockingTimes.getFirst())) {
            blockingTimes.removeFirst();
            return true;
        } else {
            return false;
        }
    }
    public boolean isTimeToUnblock() {
        if (!unblockingTimes.isEmpty() &&
                (executedTime + blockedTime == unblockingTimes.getFirst())) {
            unblockingTimes.removeFirst();
            return true;
        } else {
            return false;
        }
    }

    public int getProcessId() { return processId;  }
    public int getArrivalTime() { return arrivalTime;  }
    public int getBurstTime() { return burstTime; }
    public int getExecutedTime() { return executedTime; }
    public int getWaitingTime() { return waitingTime; }
    public int getBlockedTime() { return blockedTime; }
    public int getTotalTime() { return totalTime; }
    
    public boolean isArrived() { return arrived; }
    public boolean isReady() { return ready; }
    public boolean isActive() { return active; }
    public boolean isFinished() { return finished; }
	public boolean getBlocked() { return blocked; }

    public void incrementWaitingTime() { waitingTime++; }
    public void incrementExecutedTime() { executedTime++; }
    public void incrementBlockedTime() { blockedTime++; }

    public void setArrived(boolean arrived) { this.arrived = arrived; }
    public void setActive(boolean active) { this.active = active; }
    public void setReady(boolean ready) { this.ready = ready; }
    public void setBlocked(boolean blocked) { this.blocked = blocked; }
    public void setFinished(boolean finished) { this.finished = finished; }

    public String toString() {
        return "P" + processId + ": " + " B: " + burstTime +
                " W:" + waitingTime + " E:" + executedTime;
    }
    public String getStatus() {
        if (active) {
            return "ACTIVE";
        } else if (finished){
            return "FINISHED";
        } else if (ready) {
            return "READY";
        } else if (blocked) {
            return "BLOCKED";
        } else {
            return "NOT ARRIVED";
        }
    }
}
