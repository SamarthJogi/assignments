package hospital;

import java.net.SocketPermission;

import hospital.Patient;

public class InHousePatient extends Patient
{
    private double discount;
    public InHousePatient( int patientId, String patientName, int bedType, int noOfDays, double discount)
    {
        super(patientId, patientName, bedType, noOfDays);
        this.discount=discount;
    }

    public double getDiscount()
    {
        return discount;
    }

    public double getBillAmount()
    {
        double amount =super.getBillAmount();
        double finalAmount;
        if (amount>5000)
        {
            finalAmount=amount-(amount*(discount/100));         
        }
        else
        {
            finalAmount=amount-(amount-(amount*0.05));
        }
        return finalAmount;
    }
    public void display()
    {
        System.out.println("Patient Id      : " +getPatientId());
        System.out.println("Patient Name    : " +getPatientName());
        System.out.println("Bed Tpye        : " +getBedType());
        System.out.println("Number Of Days  : " +getNoOfDays());
        System.out.println("Discount        : " +discount+"%");
        System.out.println("Final Bill Amount(After Discount): " +getPatientId());
    }
}
