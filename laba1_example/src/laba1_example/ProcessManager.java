package laba1_example;

import java.util.ArrayList;
import java.util.List;

public class ProcessManager {
	private List<Process> processes = new ArrayList<Process>();
	
	public ProcessManager() {	}
	
	public void addNewProcess(Process process) {
		processes.add(process);
	}
	
	public void run() throws InterruptedException {
		for(Process process : processes) {
			process.solve();
		}
	}
}
