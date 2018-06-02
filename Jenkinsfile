pipeline {
    agent any
    /*agent {
        label 'Quiniela'
    }*/
    /*tools {
        maven 'M3'
    }*/
    stages {
        stage('Build NetCore') {
            steps {
                echo 'Building Webservice NetCore'
                dir ('backend/'){
                    //sh 'mvn clean compile package'
                }
            }
        }
        stage('Build Angular') {
            steps {
                echo 'Building Frontend Angular'
                dir ('frontend/'){
                    sh 'npm install'
                    sh 'npm run build'
                }
            }
        }
        stage('Running Docker') {
            steps {
                echo 'Running on Docker'
                sh 'docker-compose down'
                sh 'docker-compose up -d'
            }
        }
        stage('Liquibase') {
            steps {
                echo 'Applying database changes'
                dir ('database/liquibase/'){
                    sh '$LIQUIBASE_PATH/liquibase --changeLogFile="changesets/db.changelog-master.xml" update'
                }
            }
        }
    }
    post { 
        always { 
            deleteDir()
        }
        success {
            echo 'I succeeeded!'
        }
        unstable {
            sh 'docker-compose down'
            echo 'I am unstable :/'
        }
        failure {
            sh 'docker-compose down'
            echo 'I failed :('
        }
        changed {
            echo 'Things were different before...'
        }
    }
}