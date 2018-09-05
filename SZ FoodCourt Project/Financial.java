import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class Financial extends JFrame implements ActionListener
{
	private JButton back; 
	private JPanel panel;
	private JTextArea j;
	String userId;
	public Financial(String userId)
	{
		super("Borrowed Book");
		this.setSize(800,600);
		this.setDefaultCloseOperation(this.EXIT_ON_CLOSE);
		
		panel = new JPanel();
		panel.setBackground(new Color(0,138,150));
		panel.setBounds(0,0,800,600);
		panel.setLayout(null);
		
		back=new JButton("Back");
		back.setBackground( new Color(0,138,150));
		back.setBounds(285,350,100,50);
		panel.add(back);
		
		j=new JTextArea();
		j.setBackground(Color.WHITE);
		j.setBounds(5,5,770,540);
		j.setEditable(false);
		panel.add(j);
		
        back.addActionListener(this);
		
		this.setVisible(true);
		this.add(panel);
	}
	
	public void actionPerformed(ActionEvent a)
	{	
		if (a.getSource()==back)
		{
			this.setVisible(false);
			new ManageStudent(userId);
		}
		else{}
	}
	
}