folder_name="Assets/ScriptTemplates/DemoScripts/Scripts"

for file_name in "$folder_name"/*
do
  # Get the current date
  current_date=$(date +"%m/%d/%Y")

  # Replace the "Date created: " placeholder with the current date
  awk -v d="Date created: $current_date" '{sub(/Date created:.*/,d);print}' "$file_name" > "$file_name".tmp
  mv "$file_name".tmp "$file_name"
done