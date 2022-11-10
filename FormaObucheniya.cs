using System.ComponentModel;

namespace Приемная_комиссия
{
    public enum FormaObucheniya
    {
        /// <summary>
        /// Очное
        /// </summary>
        [Description("Очное")]
        Ochnoe,
        /// <summary>
        /// Очно-заочное
        /// </summary>
         [Description("Очно-заочное")]
        Ocno_zaochnoe,
        /// <summary>
        /// Заочное
        /// </summary>
         [Description("Заочное")]
        Zaochnoe,

    }
}
