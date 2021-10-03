import java.util.Scanner;
public class JavaExample
{
    public static void main(String args[]) 
    {
        float p, r, t, simp_interest;
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter the Principal : ");
        p = sc.nextFloat();
        System.out.print("Enter the Rate of interest : ");
        r = sc.nextFloat();
        System.out.print("Enter the Time period : ");
        t = sc.nextFloat();
        sc.close();
        simp_interest = (p * r * t) / 100;
        System.out.print("Simple Interest is: " +simp_interest);
    }
}
