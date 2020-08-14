using MSharp;

namespace Domain
{
    public class Owner : EntityType
    {
        /*M#:w[6]T-Prop:SortProperty-Type:EntityType-The Sort property of the entity should be set when a custom ToString is specified. Otherwise Database.GetList() can become very slow.*/public Owner()
        {
            Name("Owner");

            String("First name");

            String("Last name");

            ToStringExpression("FirstName + ' ' + LastName");
        }
    }
}
