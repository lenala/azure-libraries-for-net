#############################################
# Define colored output func
function title {
    LGREEN='\033[1;32m'
    CLEAR='\033[0m'

    echo -e ${LGREEN}$1${CLEAR}
}

#############################################

title 'Generating tasks list'
./ci/get_tasks_list.sh

