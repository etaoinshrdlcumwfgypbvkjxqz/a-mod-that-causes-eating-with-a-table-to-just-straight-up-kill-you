#!/bin/sh

# Do NOT change the replacement order!
# project GUID: bc9d47e4-823c-45aa-af25-f052eafee17f
# assembly GUID: 8ddcb5e9-86ba-49f1-9f4b-fe4a8f2a4567
for regexp in 's/VARIABLE_NAMESPACE/Polyipseity.RimWorld.AModThatCausesEatingWithATableToJustStraightUpKillYou/g' 's/VARIABLE_NAME/A mod that causes eating with a table to just straight up kill you/g' 's/VARIABLE_ASSEMBLY_NAME/AModThatCausesEatingWithATableToJustStraightUpKillYou/g' 's/VARIABLE_AUTHOR/polyipseity/g' 's/VARIABLE_YEAR/2022/g' 's/VARIABLE_SUPPORTED_VERSION/1.3/g' 's/VARIABLE_DESCRIPTION/This is a mod that causes eating with a table to just straight up kill you!/g' 's/VARIABLE_URL/https:\/\/github.com\/etaoinshrdlcumwfgypbvkjxqz\/unlimited-short-circuit-explosion/g' 's/bc9d47e4-823c-45aa-af25-f052eafee17f/6e93c64e-643c-4b64-9828-091a447f37eb/g' 's/8ddcb5e9-86ba-49f1-9f4b-fe4a8f2a4567/791d18fa-8588-46f6-a855-ac328d7c187c/g'; do
	echo Applying \'$regexp\'…
	find . \( -type f -wholename "$0" \) -o \( -type d -name '.git' -prune \) -o -type f -print0 | xargs -0 sed -i "$regexp"
done
