
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
public class ProcessPanel extends JPanel {
    static final int WIDTH = 110, HEIGHT = 120;

    Process process;

    public ProcessPanel(Process p) {
        this.process = p;

        setLayout(new FlowLayout(FlowLayout.CENTER));

        this.setBorder(BorderFactory.createTitledBorder("Process #" + p.getProcessId()));
        
        String waitingTime = "Waiting Time: " + String.valueOf(p.getWaitingTime());
        String serviceTime = "Executed Time: " + String.valueOf(p.getExecutedTime());
		String blockedTime = "Blocked Time: " + String.valueOf(p.getBlockedTime());

		
        this.add(new JLabel(serviceTime));
        this.add(new JLabel(waitingTime));
        this.add(new JLabel(blockedTime));

        JLabel status = new JLabel(p.getStatus());
        status.setForeground(Color.RED);
        this.add(status);
    }
    public Dimension getPreferredSize() {
        return new Dimension(WIDTH, HEIGHT);
    }
    public Dimension getMinimumSize() {
        return new Dimension(WIDTH, HEIGHT);
    }
}
