pipeline {
    agent any
    stages {
        stage('Checkout') {
            steps {
                checkout scm
            }
        }
        stage('SonarQube Analysis') {
            steps {
                script {
                    // Отримуємо шлях до сканера за його ім'ям з Global Tool Configuration
                    def scannerHome = tool name: 'dotnet-scanner', type: 'hudson.plugins.sonar.MsBuildSQRunnerInstallation'
                    
                    withSonarQubeEnv('SonarQube') {
                        // Використовуємо отриманий шлях для запуску
                        // Якщо сканер встановлений як глобальний інструмент dotnet, можна просто 'dotnet sonarscanner'
                        sh "${scannerHome}/dotnet-sonarscanner begin /k:\"my-backend-key\""
                        sh "dotnet build"
                        sh "${scannerHome}/dotnet-sonarscanner end"
                    }
                }
            }
        }
    }
}