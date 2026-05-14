string r = $@"
<!DOCTYPE html>
<html>
<head>
    <meta charset='UTF-8'>
</head>
<body>
    <style>
        body {{
            margin: 0;
            padding: 16px;
            background: #001e00;
            font-family: Arial, 'Helvetica Neue', Helvetica, sans-serif;
            color: white;
        }}

        .message {{
            display: flex;
            margin-bottom: 14px;
        }}
        .message.user {{justify-content: flex-end;}}
        .message.assistant {{justify-content: flex-start;}}
        .bubble {{
            max-width: 70%;
            padding: 12px 14px;
            border-radius: 1rem;
            line-height: 1.5;
            word-wrap: break-word;
            overflow-wrap: break-word;
        }}

        .user .bubble {{
            background: #ff5000;
            color: #fff;
        }}
        .assistant .bubble {{
            background: #005011;
            color: #fff;
        }}

        pre {{
            background: #111;
            padding: 10px;
            border-radius: .5rem;
            overflow-x: auto;
        }}

        code {{
            background: #222;
            padding: 2px 5px;
            border-radius: 4px;
            font-family: Consolas, monospace;
        }}

        pre code {{
            padding: 0;
            background: transparent;
        }}

        h1, h2, h3 {{
            margin-top: 0.5rem;
            margin-bottom: 0.5rem;
        }}
        ul, ol {{padding-left: 22px;}}
        a {{color: #004e79;}}
    </style>

    {messagesHtml}

    <script>
        window.scrollTo(0, document.body.scrollHeight)
    </script>
</body>
</html>
";