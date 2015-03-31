package laba1_example;

public class Process {
	
	private static int counter = 0;
	
	private int number;
	private double[][] A;
	private double[] B;
	
	private boolean isCompleeted = false;
	
	public Process(double[][] A, double[] B) {
		this.A = A;
		this.B = B;
		counter++;
		number = counter;
	}
	
	/*public void solve() throws InterruptedException {
		System.out.println("Work process: "+number);
		Thread.sleep(1000);
	}*/
	
	public boolean isCompleted() {
		return isCompleeted;
	}
	
	private int  i = 0;
	private int j = 0;
	
	int len = 5;
	public void step() throws InterruptedException {
		
		for(; i< A.length;) {
			for(; j < A[0].length; j++) {
				
			}
			
			System.out.println(number + ": "+ i);
			
			i++;
			break;
		}
		
		
		
		//if(isCompleted()) return;
		
		/*System.out.println("Work process: "+number );
		len--;
		
		if(len==0) {
			System.out.println("Work process " + number + " was COMPLETED");
			isCompleeted = true;
		}*/
		
		Thread.sleep(500);
	}
	
	public void pause() {};
	public void resume() {};
}