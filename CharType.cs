using System.Collections;
using System.Collections.Generic;

public enum CharType
{
    Unknown,                    // ����� �� ���� ����
    WhiteSpace,                 // ����, ��, ����
    NumberLiteral,              // ���� ���ͷ�
    StringLiteral,              // ���ڿ� ���ͷ�
    IdentifierAndKeyword,       // �ĺ���, Ű����
    OperatorAndPunctuator,      // ������, ������
    Comment //�ּ�
}