using LEARNERSIDENTITY;
class Program
{
    static void Main (String[] args)
    {
        Learners learner1 = new Learners( "Thuli"," Baloyi"," female",'T',24);
        Console.WriteLine(learner1.firstname+" "+learner1.lastname+" "+learner1.gender+" "+learner1.age+" "+learner1.initial);
    }
}


