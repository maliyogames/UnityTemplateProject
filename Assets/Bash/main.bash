folder_name="Assets/DemoScripts"

for file_name in "$folder_name"/*
do
  if [ -f "$file_name" ]; then
    # Get the current date
    current_date=$(date +"%Y-%m-%d")
  
    # Replace the "Date created: " placeholder with the current date
    awk -v d="Date created: $current_date" '{sub(/Date created:.*/,d);print}' "$file_name" > "$file_name".tmp
    mv "$file_name".tmp "$file_name"
  fi
done
