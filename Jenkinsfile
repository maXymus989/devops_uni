pipeline {
    agent any
    tools {
        sonarScannerMsBuild 'dotnet-scanner' 
    }
    stages {
        stage('Checkout') {
            steps {
                checkout scm 
            }
        }
        stage('SonarQube Analysis') {
            steps {
                withSonarQubeEnv('SonarQube') {
                    sh "dotnet-sonarscanner begin /k:\"my-key\""
                    sh "dotnet build"
                    sh "dotnet-sonarscanner end"
                }
            }
        }
    }
}