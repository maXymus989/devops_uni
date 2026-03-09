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
                withSonarQubeEnv('SonarQube') {
                    script {
                        def dotnetTools = "${HOME}/.dotnet/tools"
                        
                        sh "${dotnetTools}/dotnet-sonarscanner begin /k:\"my-backend-key\" /n:\"My Backend\" /v:\"1.0\""
                        sh "dotnet build"
                        sh "${dotnetTools}/dotnet-sonarscanner end"
                    }
                }
            }
        }
    }
}