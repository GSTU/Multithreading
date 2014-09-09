package laba1_example;

public class Process {
	
	private static int counter = 0;
	
	private int number;
	private double[][] A;
	private double[] B;
	
	public Process(double[][] A, double[] B) {
		this.A = A;
		this.B = B;
		counter++;
		number = counter;
	}
	
	public void solve() throws InterruptedException {
		System.out.println("Work process: "+number);
		Thread.sleep(1000);
	}
}
