<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>View1</title>
</head>
<body>
    <div>
        <%for (int counter = 1; counter <= 5; counter++)
          {%>
        <div><%:counter %></div>
        <% } %>
    </div>
</body>
</html>
