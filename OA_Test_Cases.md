# IT Help Desk - QA Test Planı və Ssenariləri
## 1. Routing və Endpoint Testləri
- TC-01: Ana səhifənin (/Home/Index) açılması yoxlanılması.
- TC-02: Yanlış URL daxil edildikdə 404 səhifəsinin göstərilməsi.
## 2. Middleware və Təhlükəsizlik Testləri
- TC-03: HTTP sorğularının avtomatik HTTPS-ə yönləndirilməsi (UseHttpsRedirection).
- TC-04: wwwroot daxilindəki CSS və JS fayllarının yüklənməsi (UseStaticFiles).
## 3. Xəta İdarəetməsi (Error Handling)
- TC-05: Sistemdə Gözlənilməz Xəta (Exception) baş verdikdə /Home/Error səhifəsinə yönləndirmə.
