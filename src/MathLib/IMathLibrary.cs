﻿using System;
using MathLib.Exceptions;

namespace MathLib
{
    public interface IMathLibrary
    {
        /// <summary>
        /// Pi - mathematical constant
        /// </summary>
        decimal PI { get; }

        /// <summary>
        /// Euler's number - mathematical constant
        /// </summary>
        decimal E { get; }

        /// <summary>
        /// Add two numbers
        /// </summary>
        /// <param name="a">First number (left side)</param>
        /// <param name="b">Second number (right side)</param>
        /// <returns>Addition result</returns>
        decimal Add(decimal a, decimal b);

        /// <summary>
        /// Substract two numbers
        /// </summary>
        /// <param name="a">First number (left side)</param>
        /// <param name="b">Second number (right side)</param>
        /// <returns>Substraction result</returns>
        decimal Sub(decimal a, decimal b);

        /// <summary>
        /// Multiply two numbers
        /// </summary>
        /// <param name="a">First number (left side)</param>
        /// <param name="b">Second number (right side)</param>
        /// <returns>Multiplication result</returns>
        decimal Mul(decimal a, decimal b);

        /// <summary>
        /// Divide two numbers
        /// </summary>
        /// <param name="a">Dividend (left side)</param>
        /// <param name="b">Divisor (right side). Must not be zero!</param>
        /// <exception cref="DivideByZeroException">Throws when the value of the divisor is zero</exception>
        /// <returns>Division result</returns>
        decimal Div(decimal a, decimal b);

        /// <summary>
        /// Calculate factorial
        /// </summary>
        /// <param name="n">Decimal number greater then or equal to zero</param>
        /// <exception cref="ArithmeticException">Throws when the provided number is negative</exception>
        /// <returns>Factorial result</returns>
        decimal Factorial(decimal n);

        /// <summary>
        /// Calculate exponentiation of base <c>a</c> to the power of <c>n</c>
        /// </summary>
        /// <param name="a">Base</param>
        /// <param name="n">Exponent (decimal number)</param>
        /// <exception cref="ArithmeticException">Throws when exponent is not decimal number</exception>
        /// <returns>Exponentiation result</returns>
        decimal Power(decimal a, decimal n);

        /// <summary>
        /// Calculate <c>n</c>th root of a number <c>a</c>, also known as root extraction
        /// </summary>
        /// <param name="a">Base</param>
        /// <param name="n">Root (decimal number)</param>
        /// <exception cref="ArithmeticException">Throws when the base is negative</exception>
        /// <returns>Root exraction result</returns>
        decimal Root(decimal a, decimal n);

        /// <summary>
        /// Calculate remainder of two integer division
        /// </summary>
        /// <param name="a">Dividend (left side)</param>
        /// <param name="b">Divisor (right side, decimal number). Must not be zero!</param>
        /// <exception cref="DivideByZeroException">Throws when the value of the divisor is zero</exception>
        /// <exception cref="ArithmeticException">Throws when divisor is not decimal number</exception>
        /// <returns>Integer division remainder</returns>
        decimal Modulo(decimal a, decimal b);

        /// <summary>
        /// Parse and evaluate provided mathematical expression
        /// </summary>
        /// <param name="expression">Mathematical expression eg. "2 / (1 + 2) * 5"</param>
        /// <exception cref="DivideByZeroException">Throws when division by zero happens when evaluating expression</exception>
        /// <exception cref="ArithmeticException">Throws when invalid argument occurs in math function</exception>
        /// <exception cref="ParseException">Throws when the provided string is an invalid expression</exception>
        /// <returns>Mathematical expression result</returns>
        decimal EvaluateExpression(string expression);
    }
}
