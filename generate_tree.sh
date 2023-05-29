#!/bin/bash

# Run the script by typing ./generate_tree.sh and pressing enter

# Define the maximum depth of the tree (set to 3 by default)
max_depth=6

# Define the character used for indentation (set to '|-- ' by default)
indent_char="|- "

# Define a list of folders to exclude from the tree
exclude_folders=(".vscode" ".git" "bin" "obj" "Docs")

# Define a list of file extensions to exclude from the tree
exclude_extensions=("csproj" "txt")

# Define a function to generate the tree structure
function generate_tree() {
    local dir=$1
    local indent=$2
    local current_depth=$3
    
    if [[ $current_depth -gt $max_depth ]]; then
        return
    fi
    
    local i
    for i in "$dir"/*; do
        local filename=${i##*/}
        
        if [[ -d "$i" ]]; then
            if [[ ! " ${exclude_folders[@]} " =~ " ${filename} " ]]; then
                echo "${indent}${filename}" >> tree.txt
                generate_tree "$i" "$indent$indent_char" $((current_depth+1))
            fi
        elif [[ -f "$i" ]]; then
            local extension=${filename##*.}
            if [[ ! " ${exclude_extensions[@]} " =~ " ${extension} " ]]; then
                echo "${indent}${filename}" >> tree.txt
            fi
        fi
    done
}

# Call the generate_tree function to generate the tree structure and save it to file
generate_tree "." ""

