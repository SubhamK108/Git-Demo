# Git Instructions

## How to make a Pull Request ?
- First **Fork** the original repo.

- Then clone your **Forked Repo** using the command:  
`git clone <URL>`

- Open that folder using:  
`cd <FolderName>`

- Open VSCode from that folder using:  
`code .`

- Check and Verify the Remotes using:  
`git remote -v`

- Make sure both **Your Repo URL** and **Original Repo URL** are both there. If the Original Repo URL is missing add it using:  
`git remote  add origin_2 <Original_Repo_URL>`  
After adding, verify once again using: `git remote -v`

- Make your changes in the code.

- After finishing your coding work and before **Pushing your code into your repo**, make sure to **Pull from the original repo** using:  
`git pull origin_2 main`

- Then **Add, Commit & Push** your code:  
Add your files: `git add .`  
Commit your files with a message: `git commit -m "Message"`  
Push your code into **Your Repo**: `git push -u origin main`

- Then go to your GitHub Repo and make the **Pull Request** using the already provided button.

---

## If your Pull Request is **Rejected** or if **you're asked to make changes to your code**.
- Make your changes in VSCode.

- **Pull** from the original repo using:  
`git pull origin_2 main`

- **Add, Commit & Push** your code:  
Add your files: `git add .`  
Commit your files with a message: `git commit -m "Message"`  
Push your code into **Your Repo**: `git push -u origin main`