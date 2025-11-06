package hospital;

public class Patient
{
    private int patientId;
    
    private String patientName;
    private int bedType;
    private int noOfDays;

    public int getPatientId()
    {
        return patientId;
    }
    public String getPatientName()
    {
        return patientName;
    }

    public int getBedType()
    {
        return bedType;
    }
    public int getNoOfDays()
    {
        return noOfDays;
    }
    public int getPricePerDay()
    {
        switch(bedType)
        {
            case 1:
            return 500;
            case 2:
            return 350;
            case 3:
            return 200;
            default:
            return 0;
        }   
    }
    public double getBillAmount()
    {
        return noOfDays*getPricePerDay();
    }

    public void display()
    {
        System.out.println("Patient Id    : "+patientId);
        System.out.println("Patient Name  : "+patientName);
        System.out.println("Bed Type      : "+bedType);
        System.out.println("Number Of Days: "+noOfDays);
        System.out.println("Bill Amount   : "+getBillAmount());
    }
    public Patient(int patientId, String patientName, int bedType, int noOfDays) {
        this.patientId = patientId;
        this.patientName = patientName;
        this.bedType = bedType;
        this.noOfDays = noOfDays;
    }
}
