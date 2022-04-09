using System;

namespace ClassExample
{
    /// <summary>
    /// Задаёт параметры для Васи, после прибытия в Москву.
    /// </summary>
    public class VasyaArrivedMoscow : Vasya, IVasyaFindJob
    {
        #region Methods
        /// <summary>
        /// Вася приехал в Москву.
        /// </summary>
        public override void VasyaGoToMoscow()
        {
            base.VasyaGoToMoscow();           
            this.Place = "Moscow";           
        }

        /// <summary>
        /// Вася нашёл работу в Москве.
        /// </summary>
        public void VasyaFindJob()
        {
            this.Profession = "Loader";
        }
        #endregion
    }
}
