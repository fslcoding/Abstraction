using System;
public class mobile
  {
    private string make;
    private string model;
    private int remainingMinutes;
    private int remainingTexts;
    private double costPerMonth;
    private double credit;
    
    //Default constructor
    public mobile()
    {

    }

    //Field constructor
    public mobile(string make, string model, int initialMinutes, int initialTexts, double costPerMonth, double initialCredit)
    {
      this.make = make;
      this.model = model;
      this.remainingMinutes = initialMinutes;
      this.remainingTexts = initialTexts;
      this.costPerMonth= costPerMonth;
      this.credit = initialCredit; 
    }

    public string Make
    {
      get
      {
        return make;
      }

      set
      {
        make=value;
      }
    }

    public string Model
    {
      get
      {
        return model;
      }

      set
      {
        model=value;
      }
    }

    public int RemainingMinutes
    {
      get
      {
        return remainingMinutes;
      }

      set
      {
        remainingMinutes=value;
      }
    }

    public int RemainingTexts
    {
      get
      {
        return remainingTexts;
      }

      set
      {
        remainingTexts=value;
      }
    }

    public double CostPerMonth
    {
      get
      {
        return costPerMonth;
      }

      set
      {
        costPerMonth=value;
      }
    }

    public double Credit
    {
      get
      {
        return credit;
      }

    }

    public void addCredit(double additionalCredit)
    {
      if(additionalCredit>50)
      {
        additionalCredit = 50;
        Console.WriteLine("You can only add additional credit of £50 per transaction");
        credit = credit+additionalCredit;
      }
    }


  }
