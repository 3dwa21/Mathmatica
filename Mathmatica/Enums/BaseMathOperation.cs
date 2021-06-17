using System;
using System.Collections.Generic;
using System.Text;

namespace Mathmatica.Enums
{
    public enum BaseMathOperation
    {
        Add,
        Substract,
        Multiply,
        Divide
    }
    /*public class BaseMathOperation
    {
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// Properties & Fields
        /// 
        public int ID { get; private set; }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Constructors
        #region Contructors
        /// <summary>
        ///     Contructor for BaseMathOperation enum class
        /// </summary>
        /// <param name="id"></param>
        private BaseMathOperation(int id)
        {
            this.ID = id;
        }
		#endregion

		//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		// Static members
		#region Static members
		public static BaseMathOperation Add { get { return new BaseMathOperation(1); } }
        public static BaseMathOperation Substract { get { return new BaseMathOperation(2); } }
        public static BaseMathOperation Multiply { get { return new BaseMathOperation(3); } }
        public static BaseMathOperation Divide { get { return new BaseMathOperation(4); } }
        #endregion

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Operators
        #region Operators
        /// <summary>
        ///		Compare two BaseMathOperation to be equal.
        /// </summary>
        /// <param name="enum1"></param>
        /// <param name="enum2"></param>
        /// <returns></returns>
        public static Boolean operator ==(BaseMathOperation enum1, BaseMathOperation enum2)
        {
            if (Utils.IsAnyNull(enum1, enum2))
            {
                throw new ArgumentNullException();
            }

            if (enum1.ID == enum2.ID)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        ///		Compare two BaseMathOperation to be not equal.
        /// </summary>
        /// <param name="enum1"></param>
        /// <param name="enum2"></param>
        /// <returns></returns>
        public static Boolean operator !=(BaseMathOperation enum1, BaseMathOperation enum2)
        {
            if (Utils.IsAnyNull(enum1, enum2))
            {
                throw new ArgumentNullException();
            }

            if (enum1.ID != enum2.ID)
            {
                return true;
            }
            return false;
        }
        #endregion

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Methods
        #region Methods
        /// <summary>
        ///		Checks Equality
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is BaseMathOperation operation &&
                   ID == operation.ID;
        }

        /// <summary>
        ///     Get Member by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static BaseMathOperation FindClockEvent(int id)
        {
            if (id == BaseMathOperation.Add.ID)
            {
                return BaseMathOperation.Add;
            }
            else if (id == BaseMathOperation.Substract.ID)
            {
                return BaseMathOperation.Substract;
            }
            else if (id == BaseMathOperation.Multiply.ID)
            {
                return BaseMathOperation.Multiply;
            }
            else if (id == BaseMathOperation.Divide.ID)
            {
                return BaseMathOperation.Divide;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///		Returns Hash Code
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return 1213502048 + ID.GetHashCode();
        }
        #endregion
    }*/
}
