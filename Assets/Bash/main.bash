folder_name="Assets"
current_date=$(date +"%Y-%m-%d")

# Find all .cs files in the Assets folder and its subdirectories
find "$folder_name" -type f -name "*.cs" | while read file_name; do

  # Check if the file contains the date comment
  if grep -q "Date updated: " "$file_name"; then
    # Replace the "Date created: " placeholder with the current date
    sed "s/Date updated:.*/Date created: $current_date/" "$file_name" > "$file_name".tmp
  else
    # Add the date comment if it does not exist
    echo "// Date updated: $current_date" | cat - "$file_name" > "$file_name".tmp
  fi

  mv "$file_name".tmp "$file_name"

done
