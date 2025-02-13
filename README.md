# 한
 ![intro](https://github.com/Luigi38/Han/blob/main/test.png?raw=true)
 > [!NOTE]
 > 하나의, 프로그래밍 언어
> 

## 기능
- 출력: `print`
- 함수: `label`
- 변수: `define`
- 주석: `#`

## 예제
```rpy
define value = 13 # 전역 변수

label start:
    print "Hello, world!"
    
    # 변수 할당
    define add = value + 4
    print "13 + 4 = "
    print add
```

출력 결과
```
Hello, world!
13 + 4 = 
17
```

## 인터프리터 사용법
```c#
string path = "filename.han";
var scanner = new Scanner();
Parser parser;
Interpreter interpreter = new Interpreter();

if (!File.Exists(path))
{
    Console.WriteLine("오류! 파일이 존재하지 않습니다.");
    return;
}

string sourceCode = File.ReadAllText(path);
List<Token> tokenList = scanner.Scan(sourceCode);
parser = new Parser(ref tokenList);

Program syntaxTree = parser.Parse();
interpreter.Interpret(syntaxTree);
```

## 소스코드 개요
- [Scanner.cs](https://github.com/Luigi38/Han/blob/main/Scanner.cs): **어휘 분석**을 통한 토큰 분리
- [Parser.cs](https://github.com/Luigi38/Han/blob/main/Parser.cs): **구문 분석**을 통한 구조 분석 및 변환
- [Interpreter.cs](https://github.com/Luigi38/Han/blob/main/Interpreter.cs): **인터프리터**를 구현하기 위해 명령 해석 및 실행

## 참조
- [컴파일러 만들기를 읽고](https://velog.io/@ghkdgus29/%EC%BB%B4%ED%8C%8C%EC%9D%BC%EB%9F%AC-%EB%A7%8C%EB%93%A4%EA%B8%B0%EB%A5%BC-%EC%9D%BD%EA%B3%A0)
