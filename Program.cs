using System;

class Program
{

        void Checklimit(int murls) {
        bool inflag = false;
        while(inflag != true){
        if(murls < 0 || murls > 30){
            Console.WriteLine("Enter again");
            murls = Convert.ToInt32(Console.ReadLine());
        }
        else{
            //Console.WriteLine("limit ok");
            inflag = true;
        }
        }
        }

        void displayNmrls(int mural_number, string type_mural){
            string disp_num = mural_number.ToString();
            string totalTitle = $"Number of {type_mural} mural orders: {disp_num}";
            Console.WriteLine(totalTitle);

        }

         static int[] AddArrays(int[] array1, int[] array2)
    {
        if (array1.Length != array2.Length)
        {
            throw new ArgumentException("Arrays must have the same length.");
        }

        int[] result = new int[array1.Length];

        for (int i = 0; i < array1.Length; i++)
        {
            result[i] = array1[i] + array2[i];
        }

        return result;
    }

        int revenueExpt(int muralsrev, bool mrlFlag){
            int revenueExt = 0;
            if(mrlFlag == true){
             revenueExt = muralsrev * 750;
            string revTitle = $"Expected revenue from exterior murals: ${revenueExt.ToString()}";
            Console.WriteLine(revTitle);
            }
            else{
             revenueExt = muralsrev * 500;
            string revTitle = $"Expected revenue from interior murals: ${revenueExt.ToString()}";
            Console.WriteLine(revTitle);
            }
            return revenueExt;
        }

           int[] storemrlquant(string mrlalp){
            int[] ordstat = new int[4];
           switch(mrlalp){
            case "L":
            ordstat[0]++;
                break;
            case "S":
             ordstat[1]++;
                break;
            case "A":
             ordstat[2]++;
                break;
            case "O":
             ordstat[3]++;
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
           }
           return ordstat;
           }

    static void Main()
    {
        Program pr = new Program();

        string name = "John Doe";
        string SiD  =  "StudentID";
        int borderLength = name.Length + SiD.Length + 4; // 2 asterisks on each side

        string border = new string('*', borderLength);
        string borderedName = $"* {name} {SiD} *";

        Console.WriteLine(border);
        Console.WriteLine(borderedName);
        Console.WriteLine(border);

        Console.WriteLine("Enter the number of interior murals(0 to 30):");
        int interior_mural = Convert.ToInt32(Console.ReadLine());
        pr.Checklimit(interior_mural);
        Console.WriteLine("Enter the number of exterior murals(0 to 30):");
        int exterior_mural = Convert.ToInt32(Console.ReadLine());
        pr.Checklimit(exterior_mural);

        pr.displayNmrls(interior_mural, "interior");
        pr.displayNmrls(exterior_mural, "exterior");

       int extrev = pr.revenueExpt(interior_mural, false);
        int intrev = pr.revenueExpt(exterior_mural, true);
        int totrev = extrev + intrev;
        string totrevHed = $"Total expected revenue: ${totrev}";
        Console.WriteLine(totrevHed);

        if(interior_mural > exterior_mural){
            Console.WriteLine("Interior murals are becoming popular!");
        }
        else if(interior_mural == exterior_mural){
            Console.WriteLine("Both are equally prefered");
        }
        else
        {
            Console.WriteLine("Exterior murals are becoming popular!");
        }

        string[] mrlcode = {"landscape", "seascape", "abstract", "other"};
        //string[] mrlAlph = {"L", "S", "A", "O"};
        string[] CustomerName = new string[interior_mural];
        int[] ordnum = new int[4];

        for(int i = 1; i <= interior_mural; i++){
        string Head1 = $"Enter the customer name {i.ToString()}:";
        Console.WriteLine(Head1);
        CustomerName[i-1] = Console.ReadLine();
        Console.WriteLine("Mural options are");
        string mrlopt = $"L for {mrlcode[0]} \n S for {mrlcode[1]} \n A for {mrlcode[2]} \n O for {mrlcode[3]}";
        Console.WriteLine(mrlopt);
        string mrlcodeHed = $"Enter the mural code {i.ToString()} (L, S, A, O):";
        Console.WriteLine(mrlcodeHed);

        string MrlUsrAlph = Console.ReadLine();
        ordnum = AddArrays(ordnum, pr.storemrlquant(MrlUsrAlph));
        


        }
        for(int i = 0; i < ordnum.Length; i++){
           string Headord = $"number of customers ordering {mrlcode[i]} murals: {ordnum[i]}";
        Console.WriteLine(Headord);
        }

    }


}