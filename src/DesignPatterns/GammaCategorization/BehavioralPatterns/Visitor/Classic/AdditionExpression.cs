﻿namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Visitor.Classic;

public class AdditionExpression : Expression
{
    public readonly Expression Right;
    public readonly Expression Left;

    public AdditionExpression(Expression left, Expression right)
    {
        Left = left;
        Right = right;
    }

    public override void Accept(IExpressionVisitor visitor)
    {
        visitor.Visit(this);
    }
}