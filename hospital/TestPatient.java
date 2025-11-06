package hospital;

public class TestPatient
{
        public static void main(String[] args)
        {
            Patient p1 = new Patient(101, "ABCD", 1, 8);
            System.out.println("=== Patient Details ===");
            p1.display();
            System.out.println();
            InHousePatient p2 = new InHousePatient(201, "Jane Smith", 2, 20, 10);
            System.out.println("=== In-House Patient Details ===");
            p2.display();
        }
    
}
