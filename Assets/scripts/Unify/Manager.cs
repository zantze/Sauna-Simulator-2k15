public class Manager : Singleton<Manager> {
	protected Manager () {} // guarantee this will be always a singleton only - can't use the constructor!
	
	public float mySens;

	public float bodyTemp = 37;
	public float outsideTemp = -23;
	public float currentTemp;

}