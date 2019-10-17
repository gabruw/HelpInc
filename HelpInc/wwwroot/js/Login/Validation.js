$(document).ready(function () {
    $('#Form-login').form({
        fields: {
            email: {
                identifier: 'email',
                rules: [
                    {
                        type: 'empty',
                        prompt: 'Por favor, preencha o campo "E-mail"'
                    },
                    {
                        type: 'email',
                        prompt: 'Por favor, entre com e-mail válido'
                    }
                ]
            },
            password: {
                identifier: 'password',
                rules: [
                    {
                        type: 'empty',
                        prompt: 'Por favor, preencha o campo "Senha"'
                    },
                    {
                        type: 'minLength[6]',
                        prompt: 'A senha deve conter no minímo 6 caracteres'
                    },
                    {
                        type: 'maxLength[40]',
                        prompt: 'A senha deve conter no maxímo 40 caracteres'
                    },
                    {
                        type: 'regExp[/^(?=.*[a-z])(?=.*[A-Z])(?=.*[$*&@#])(?!.*\s).*$/]',
                        prompt: 'A senha deve conter 1 caractere maíusculo, minusculo, número e simbolo "$*&@#"'
                    }
                ]
            }
        },
        on: 'blur',
        inline: 'true'
    });
});