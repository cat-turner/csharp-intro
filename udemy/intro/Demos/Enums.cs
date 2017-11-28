namespace Demos
{
    /* Enums are data types that represent a set of name/value pairs (constants) */
    public class Enums
    {
        /* Instead of storing related data
        seperately, like this... */
        const int RegularAirMail = 1;
        const int RegisteredAirMail = 2;
        const int Express = 3;

        /* use Enums to store related data */
        public enum ShippingMethod
        {
            RegularAirMail = 1, // note, use commas (,)
            RegisteredAirMail = 2,
            Express = 2
        }
    }
}

// Enums are integers
// the value of the first member of an enum (if not set) is 0
