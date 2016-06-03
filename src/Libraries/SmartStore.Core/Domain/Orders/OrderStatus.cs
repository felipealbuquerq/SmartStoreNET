namespace SmartStore.Core.Domain.Orders
{
    /// <summary>
    /// Represents an order status enumeration
    /// </summary>
    public enum OrderStatus : int
    {
        /// <summary>
        /// Pending
        /// </summary>
        Pendente = 10,
        /// <summary>
        /// Processing
        /// </summary>
        Processando = 20,
        /// <summary>
        /// Complete
        /// </summary>
        Completo = 30,
        /// <summary>
        /// Cancelled
        /// </summary>
        Cancelado = 40
    }
}
