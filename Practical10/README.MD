 1. Add a New Web Form.
 2. Drag and Drop ScriptManager at Top of the Page(Must be Top of the all Controls).
 3. Drag and Drop UpdatePanel From Toolbox.
 4. Drag and Drop Label In UpdatePanel.
 5. Drag and Drop Add Timer Control In UpdatePanel From Toolbox.
 6. Go to Timer Control Properties and Change the Interval to 1000.
 7. Now to Double Click on TimerControl to Generate Event.
 8. Write the Follwing Code in Event Function.
 `Label1.Text = DateTime.Now.ToString();`