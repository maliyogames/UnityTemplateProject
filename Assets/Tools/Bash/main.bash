folder_name="Assets"
current_date=$(date +"%Y-%m-%d")

# Find all .cs files in the Assets folder and its subdirectories
find "$folder_name" -type f -name "*.cs" | while read file_name; do

  # Check if the file contains the date comment and replace it
  awk -v d="Date updated: $current_date" '
    /Date updated: / { sub(/Date updated:.*/,d); print; next }
    { print }
  ' "$file_name" > "$file_name".tmp

  mv "$file_name".tmp "$file_name"

done
