using System;

namespace LightMessager.Model
{
    // ˵��������������Ҫ����Щö��ֵ��λ���㣬ֻ���޸���Ϣ״̬ʱ��Ҫһ���Ա�����״ֵ̬��������Flags
    [Flags]
    public enum MessageState
    {
        None = 0,
        /// <summary>
        /// Created: 1
        /// </summary>
        Created = 1 << 0,
        /// <summary>
        /// Confirmed: 2
        /// </summary>
        Confirmed = 1 << 1,
        /// <summary>
        /// Consumed: 4
        /// </summary>
        Consumed = 1 << 2,
        /// <summary>
        /// Error: 8
        /// </summary>
        Error = 1 << 3,
        /// <summary>
        /// Error_Unroutable: 16
        /// </summary>
        Error_Unroutable = 1 << 4,
        /// <summary>
        /// Error_NoExchangeFound: 32
        /// </summary>
        Error_NoExchangeFound = 1 << 5
    }
}
