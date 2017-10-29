import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class Control {
    private JPanel mainPanel;
    private JPanel gaussPanel;
    private JPanel bareissPanel;
    private JPanel transformationPanel;
    private JPanel information;

    // Cada botón debe guiar a su respectivo panel
    private JButton gaussButton;
    private JButton transformaciónLinealButton;
    private JButton bareissButton;
    private JButton informaciónButton;
    private JButton salirButton;

    public Control() {

        salirButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                System.exit(1);
            }
        });

        gaussButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                gaussPanel = new JPanel();
                mainPanel.setVisible(false);
                gaussPanel.setVisible(true);
            }
        });
        bareissButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                bareissPanel = new JPanel();
                mainPanel.setVisible(false);
                bareissPanel.setVisible(true);
            }
        });
        transformaciónLinealButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                transformationPanel = new JPanel();
                mainPanel.setVisible(false);
                transformationPanel.setVisible(true);
            }
        });
        informaciónButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                information = new JPanel();
                mainPanel.setVisible(false);
                information.setVisible(true);
            }
        });
    }
}
