using System;

public class EdadInvalidaException : Exception
{
    public int EdadIngresada { get; }

    public EdadInvalidaException() : base() { }

    public EdadInvalidaException(string message) : base(message) { }

    public EdadInvalidaException(string message, Exception innerException) 
        : base(message, innerException) { }

    public EdadInvalidaException(string message, int edadIngresada) 
        : base(message)
    {
        EdadIngresada = edadIngresada;
    }
}