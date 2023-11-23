# APIEvent
1. Get_ReturnOk:
הפונקציה בודקת את פונקציית ה-Get() במחלקה EventsController ומוודאת שהתוצאה שהיא מחזירה היא מסוג OkObjectResult. זאת אומרת שהבדיקה תצליח אם כשנקראה פונקציית ה-Get() תחזיר תשובה מסוג OkObjectResult.

2. GetById_ReturnNotFound:
הפונקציה בודקת את פונקציית ה-Get(int id) במחלקה EventsController ומוודאת שהתוצאה שהיא מחזירה היא מסוג NotFoundResult. זאת אומרת שהבדיקה תצליח אם כשנקראה פונקציית ה-Get(int id) עם מזהה קיים, היא תחזיר תשובה מסוג NotFoundResult.
3. Post_ReturnBadRequest:
פונקציה זו בודקת את הפונקציה Post() במחלקה EventsController. תחילה הוא יוצר מופע חדש של EventsController ואובייקט invalidEvent, המייצג אירוע לא חוקי. לאחר מכן, הוא קורא לפונקציה Post() עם ה-invalidEvent כארגומנט. לאחר מכן, הפונקציה טוענת שהתוצאה המוחזרת על ידי הפונקציה Post() היא מסוג BadRequestResult. המשמעות היא שהבדיקה תעבור אם הפונקציה Post() תחזיר BadRequestResult.

4. Put_ReturnInternalServerError:
פונקציה זו בודקת את הפונקציה Put() במחלקה EventsController. הוא יוצר מופע חדש של EventsController, מגדיר משתנה invalidId (המייצג מזהה לא חוקי) ואובייקט updatedEvent (המייצג אירוע חוקי). לאחר מכן, הפונקציה קוראת לפונקציה Put() עם ה-invalidId ו-updateEvent כארגומנטים. הוא טוען שהתוצאה המוחזרת על ידי הפונקציה Put() היא מסוג InternalServerErrorResult. הבדיקה תעבור אם הפונקציה Put() תחזיר InternalServerErrorResult.

5. Delete_ReturnUnauthorized:
פונקציה זו בודקת את הפונקציה Delete() במחלקה EventsController. זה יוצר מופע חדש של EventsController ומגדיר משתנה unauthorizedId (המייצג מזהה חוקי). לאחר מכן, הפונקציה קוראת לפונקציה Delete() עם ה-unauthorizedId כארגומנט. הוא טוען שהתוצאה המוחזרת על ידי הפונקציה Delete() היא מסוג UnauthorizedResult. הבדיקה תעבור אם הפונקציה Delete() תחזיר UnauthorizedResult.
