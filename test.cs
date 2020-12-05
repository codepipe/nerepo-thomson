pipeline {
agent any
stages {
stage ("this is the first stage") {
steps {
echo "done successfully"
}
}
}
