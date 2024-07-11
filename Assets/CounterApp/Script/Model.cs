using System;

namespace CounterApp
{
    public class Model
    {
        /// <summary>
        /// 数量
        /// </summary>
        private static int mCount = 0;

        public static Action<int> OnCountChanged;

        /// <summary>
        /// 通过Count来访问mCount
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
