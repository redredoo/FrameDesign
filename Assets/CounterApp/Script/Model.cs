using System;

namespace CounterApp
{
    public class Model
    {
        /// <summary>
        /// ����
        /// </summary>
        private static int mCount = 0;

        public static Action<int> OnCountChanged;

        /// <summary>
        /// ͨ��Count������mCount
        /// </summary>
        public static int Count
        {
            get
            {
                return mCount;
            }
            set
            {
                if (value != mCount)
                {
                    mCount = value;

                    OnCountChanged?.Invoke(value);
                }
            }
        }

    }
}
