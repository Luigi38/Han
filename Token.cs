using System;
using System.Collections;
using System.Collections.Generic;

public class Token
{
    public ArgumentKind Kind { get; set; } = ArgumentKind.Unknown;
    public string Content { get; set; }

    public Token(ArgumentKind kind)
    {
        this.Kind = kind;
    }

    public Token(ArgumentKind kind, string content)
    {
        this.Kind = kind;
        this.Content = content;
    }

    public override string ToString()
    {
        return $"Token(kind={Kind}, content='{Content}')";
    }
}