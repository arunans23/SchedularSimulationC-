
import java.awt.event.*;
import java.awt.*;
import javax.swing.*;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Sivakar
 */
public class SchedulerGUI extends JFrame implements ActionListener {
    private static final int WIDTH = 800, HEIGHT = 160;
    Scheduler scheduler;
    JPanel queue;
    JPanel blockedItems;
    //JPanel finishedItems;
	ProgressPanel progress;
	
	JTextField inputField;
	JButton addProcess;
	JButton loadFromFile;
    JButton next;
	JButton autoRun;
	JSpinner timeQuantum;
	JLabel details;
	JPanel controls;

    public SchedulerGUI() {
        super("Round Robin Scheduler Simulation");
        scheduler = new Scheduler();
        scheduler.loadProcesesDataFromFile();

        queue = new JPanel();
        queue.setBorder(BorderFactory.createTitledBorder("Ready Queue"));
        queue.setLayout(new FlowLayout(FlowLayout.LEFT));
        queue.setPreferredSize(new Dimension(WIDTH, HEIGHT));
        queue.setMinimumSize(new Dimension(WIDTH, HEIGHT));

        blockedItems = new JPanel();
        blockedItems.setBorder(BorderFactory.createTitledBorder("Blocked Processs"));
        blockedItems.setLayout(new FlowLayout(FlowLayout.LEFT));
        //blockedItems.setPreferredSize(new Dimension(WIDTH, HEIGHT));
        //blockedItems.setMinimumSize(new Dimension(WIDTH, HEIGHT));

//        finishedItems = new JPanel();
//        finishedItems.setBorder(BorderFactory.createTitledBorder("Finished Processs"));
//        finishedItems.setLayout(new FlowLayout(FlowLayout.LEFT));
//        finishedItems.setPreferredSize(new Dimension(WIDTH, HEIGHT));
//        finishedItems.setMinimumSize(new Dimension(WIDTH, HEIGHT));

		inputField = new JTextField(10);
		addProcess = new JButton("Add Process");
		loadFromFile = new JButton("Load From File");
		loadFromFile.addActionListener(this);
        next = new JButton("Next");
        next.addActionListener(this);
		timeQuantum = new JSpinner();
		autoRun = new JButton("Auto Run");
		autoRun.addActionListener(this);
		controls = new JPanel();
		controls.setLayout(new FlowLayout());
		controls.add(inputField);
		controls.add(addProcess);
		controls.add(loadFromFile);
		controls.add(next);
		controls.add(autoRun);
		
		progress = new ProgressPanel(scheduler.getAllProcess());
		
		details = new JLabel();
		
		
        refreshComponents();

        this.setLayout(new BoxLayout(getContentPane(), BoxLayout.Y_AXIS));
		this.getContentPane().add(controls);
		this.getContentPane().add(details);
        this.getContentPane().add(queue);
        this.getContentPane().add(blockedItems);
        //this.getContentPane().add(finishedItems);
		
		this.getContentPane().add(new JLabel("A: Active R: Ready B: Blocked"
			+ " N: Not Arrived  F: Finished"));
		this.getContentPane().add(new JScrollPane(progress, 
				JScrollPane.VERTICAL_SCROLLBAR_AS_NEEDED, 
				JScrollPane.HORIZONTAL_SCROLLBAR_AS_NEEDED));
        this.getContentPane().add(next);
        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        this.pack();
        this.setLocationRelativeTo(null);
        this.setVisible(true);
    }
    private void refreshComponents() {
        queue.removeAll();
        queue.repaint();
        queue.revalidate();
        blockedItems.removeAll();
        blockedItems.repaint();
        blockedItems.revalidate();
//        finishedItems.removeAll();
//        finishedItems.repaint();
//        finishedItems.revalidate();

        ProcessPanel p;
        if (scheduler.getCurrentProcess() != null) {
            p = new ProcessPanel(scheduler.getCurrentProcess());
            queue.add(p);
        }
        for (Process process: scheduler.getReadyQueue()) {
            p = new ProcessPanel(process);
            queue.add(p);
        }
        for (Process process: scheduler.getBlockedItems()) {
            p = new ProcessPanel(process);
            blockedItems.add(p);
        }
//        for (Process process: scheduler.getFinishedItems()) {
//            p = new ProcessPanel(process);
//            finishedItems.add(p);
//        }
		details.setText("Current Time: " + scheduler.getCurrentTime()
			+ " Time Quantum: " + scheduler.getTimeQuantum()
			+ " Time Until Preemption: " + scheduler.getTimeUntilPreemption()
			+ " Idle Time: " + scheduler.getIdleTime());
		
		progress.next(scheduler.getCurrentTime());
    }

    @Override
    public void actionPerformed(ActionEvent e) {
		if (e.getSource() == next) {
			scheduler.nextClockCycle();
			refreshComponents();
		} else if (e.getSource() == autoRun) {
			Timer timer = new Timer(1000, null);
			timer.addActionListener(new ActionListener() {
				public void actionPerformed(ActionEvent e) {
					scheduler.nextClockCycle();
					refreshComponents();
				}
			});
			timer.start();
		}
    }
    public static void main(String[] args) {
        new SchedulerGUI();
    }
}

