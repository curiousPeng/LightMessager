using System;

namespace LightMessager.Model
{
    // ˵��������������Ҫ����Щö��ֵ��λ���㣬ֻ���޸���Ϣ״̬ʱ��Ҫһ���Ա�����״ֵ̬��������Flags
    [Flags]
    public enum MessageState
    {
        /// <summary>
        /// Created: 0
        /// </summary>
        Created = 0,
        /// <summary>
        /// Error: 1
        /// </summary>
        Error = 1 << 0,
        /// <summary>
        /// Error_Unroutable: 2
        /// </summary>
        Error_Unroutable = 1 << 1,
        /// <summary>
        /// Error_NoExchangeFound: 4
        /// </summary>
        Error_NoExchangeFound = 1 << 2,
        /// <summary>
        /// Confirmed: 8
        /// </summary>
        Confirmed = 1 << 3,
        /// <summary>
        /// Consumed: 16
        /// </summary>
        Consumed = 1 << 4
    }
}
