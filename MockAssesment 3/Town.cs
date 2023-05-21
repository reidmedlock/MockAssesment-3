using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace MockAssesment_3
{
    public class Town
    {   
        
        public List<Villager> villagers = new List<Villager>(); 

     
        public Town( int  farmer1, int slacker1, int slacker2, int slacker3 ) 
        {
            int farmer = farmer1;
            int slacker = slacker1 + slacker2 + slacker3;
            
        }


    }

    public int Harvest()
    {
        return Farm
    }
    public int CalcFoodConsumption()
    {
        
    }

    public bool SurviveTheWinter()
    {
        
        if (CalcFoodConsumption <= Harvest)
        {
            return true;
        } 

        else { return false; } 
    }
    
}







   






}
    









public bool SurviveTheWinter()
{
    return
}