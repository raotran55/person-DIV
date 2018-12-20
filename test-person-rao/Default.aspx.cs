using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;

public partial class _Default : System.Web.UI.Page
{
    public static int totalRecords;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    [WebMethod]
    public static string addNew(List<string> list)
    {//	
        string html = getAllRecords(list);

        return html;
    }
    [WebMethod]
    public static string addNewPerson(List<string> list)
    {//	
        string ret = getPersonRecords();
        string bgclass = "";
        totalRecords = totalRecords + 1;
        int i = totalRecords;
        if (i % 2 == 0)
        {
            bgclass = "bg white";
        }
        else
        {
            bgclass = "bg bg-success";
        }
        ret += "<div class='row rowitems " + bgclass + "'" + " >";
        ret += "<div class='col-md-1 item'>" + i.ToString() + "</div>";
        ret += "<div class='col-md-2  item'>" + list[0] + "</div>";
        ret += "<div class='col-md-2  item'>" + list[1] + "</div>";
        ret += "<div class='col-md-2  item'>" + list[2] + "</div>";
        ret += "<div class='col-md-2  item'>" + list[3] + "</div>";
        ret += "<div class='col-md-2  item'>" + list[4] + "</div>";
        ret += "<div class='col-md-1><button class='btn btn-info'><span class='glyphicon glyphicon-pencil'></span></button></div>";
        ret += "</div>";
       // totalRecords = i;
        return ret;
    }
    [WebMethod]
    public static int getCount(List<string> list)
    {//	
        int i = totalRecords;
        return i;
    }
    [WebMethod]
    public static string testStarter(List<string> list)
    {//	
        // build Person Search page
        string html = getAllRecords(list);

       
        return html;
    }
    public static string getAllRecords(List<string> list)
    {     	
        // build Person Search page
        string html = @"<div class='container container-fluid'><div id='page-header' class='page-header'><h3>Person Search Demo Application</h3></div></div>
 <div class='container container-fluid' style='border:0px solid #cecece;'>";
        html += "<div class='row bg bg-info'>";
        html += "<div class='col-md-1 '>";
        html += " <div class='pull-left'><button type='button' class='btn btn-success pull-left'>Search <span class='badge'>Filter</span></button></div>";
        html += "</div>";
        html += " <div class='col-md-2'>";
        html += " <input id='myInput' class='form-control pull-left' type='text' placeholder='Search ....' style='margin-top:3px;'/>";
        html += "</div>";
        html += "</div>";
        html += @"
 <div class='row bg bg-primary header-th'>
 <div class='col-md-1 th'>Id</div>
 <div class='col-md-2 th'>First Name</div>
 <div class='col-md-2 th'>Last Name</div>
 <div class='col-md-2 th'>Date of Birth</div>
 <div class='col-md-2 th'>Gender</div>
 <div class='col-md-2 th'>State Code</div>
 <div class='col-md-1 th'>Edit</div>
 </div> 
";
        html += "<div id='myDIV'>";
        string str = getPersonRecords();
        html += str;
        //
        if (list[0] == "Add")
        {
            html += list[1];
            totalRecords = totalRecords + 1;
        }
        //
        html += "</div>";
        //
       
        //
        html += "</div>";
        // model section
        html += "<div id='editModalContent'>" + getEditModal() + "</div>";
        html += "<div id='newModalContent'>" + getNewModal() + "</div>";


        return html;
    }

    public static string getPersonRecords()
    {
        string ret = "";
        string bgclass = "";
        for (int i = 1; i <= 10; i++)
        {
            if (i % 2 == 0)
            {
                bgclass = "bg white";
            }
            else
            {
                bgclass = "bg bg-success";
            }
            List<string> rowrec = getRowRecord(i);
            ret += "<div class='row rowitems " + bgclass + "'" + " >";
            ret += "<div class='col-md-1 item'>" + i.ToString() + "</div>";
            ret += "<div class='col-md-2  item'>" + rowrec[0] + "</div>";
            ret += "<div class='col-md-2  item'>" + rowrec[1] + "</div>";
            ret += "<div class='col-md-2  item'>" + rowrec[2] + "</div>";
            ret += "<div class='col-md-2  item'>" + rowrec[3] + "</div>";
            ret += "<div class='col-md-2  item'>" + rowrec[4] + "</div>";
            ret += "<div class='col-md-1><button class='btn btn-info'><span class='glyphicon glyphicon-pencil'></span></button></div>";

            ret += "</div>";
            totalRecords = i;
        }
        return ret;
    }
    public static List<string> getRowRecord(int rowindex)
    {
        List<string> rowrecord = new List<string>();
        if (rowindex == 1)
        {
            rowrecord = new List<string>() { "John", "An", "10/10/1988", "M", "AA" };

        }
        if (rowindex == 2)
        {
            rowrecord = new List<string>() { "Jennifer", "Haw", "10/10/1988", "F", "BB" };

        }
        if (rowindex == 3)
        {
            rowrecord = new List<string>() { "Jennifer", "Bass", "10/10/1988", "F", "CC" };

        }
        if (rowindex == 4)
        {
            rowrecord = new List<string>() { "John", "Doe", "10/10/1988", "M", "DD" };

        }
        if (rowindex == 5)
        {
            rowrecord = new List<string>() { "Jim", "Jones", "10/10/1988", "M", "CC" };

        }
        if (rowindex == 6)
        {
            rowrecord = new List<string>() { "James", "Gomersall", "10/10/1988", "M", "EE" };

        }
        if (rowindex == 7)
        {
            rowrecord = new List<string>() { "Alvin", "Kline", "10/10/1988", "M", "FF" };

        }
        if (rowindex == 8)
        {
            rowrecord = new List<string>() { "Johnny", "Young", "10/10/1988", "M", "GG" };

        }
        if (rowindex == 9)
        {
            rowrecord = new List<string>() { "Mike", "Kim", "10/10/1988", "M", "HH" };

        }
        if (rowindex == 10)
        {
            rowrecord = new List<string>() { "Jeff", "Synder", "10/10/1988", "M", "JJ" };

        }
        return rowrecord;
    }
    public static string getEditModal()
    {//	
        string html = @"
<div class='modal fade' id='editModal'>
  <div class='modal-dialog'>
    <div class='modal-content'>
      <div class='modal-header'>
        <button type='button' class='close' data-dismiss='modal' aria-label='Close'><span aria-hidden='true'>&times;</span></button>
        <h4 class='modal-title'>Edit Person</h4>
        <div id='editmessage' style='display:none;color:red;font-size:16px;'></div>
      </div>
      <div class='modal-body'>
      <div class='form-group'>
       <label for='edit-id' class='col-sm-4 controllabel'>Person Id</label>
        <input type='text' class='form-control' id='edit-id' readonly/>
      </div>
      <div class='form-group'>
       <label for='edit-firstname' class='col-sm-4 controllabel'>First Name</label>
        <input type='text' class='form-control' id='edit-firstname'/>
      </div>
      <div class='form-group'>
        <label for='edit-lastname' class='col-sm-4 controllabel'>Last Name</label>
        <input type='text' class='form-control' id='edit-lastname'/>
      </div>
      <div class='form-group'>
        <label for='edit-dob' class='col-sm-4 controllabel'>Date of Birth</label>
        <input type='text' class='form-control' id='edit-dob'/>
      </div>
       <div class='form-group'>
        <label for='edit-gender' class='col-sm-4 controllabel'>Gender</label>
        <input type='text' class='form-control' id='edit-gender'/>
      </div>
      <div class='form-group'>
        <label for='edit-code' class='col-sm-4 controllabel'>State Code</label>
        <input type='text' class='form-control' id='edit-code'/>
      </div>
      
      </div>
      <div class='modal-footer'>
        <button type='button' class='btn btn-orange' data-dismiss='modal'>Close</button>
        <button id='edit-btn' type='button' class='btn btn-primary'>Save changes</button>
      </div>
    </div><!-- /.modal-content -->
  </div><!-- /.modal-dialog -->
</div><!-- /.modal -->
";
        return html;
    }
    public static string getNewModal()
    {//	
        string html = @"
<div class='container'>
  
  <!-- Trigger the modal with a button -->
  <button type='button' class='btn btn-info' data-toggle='modal' data-target='#myModal'>Add New Person</button>

  <!-- Modal -->
  <div class='modal fade' id='myModal' role='dialog'>
    <div class='modal-dialog'>
    
      <!-- Modal content-->
      <div class='modal-content'>
        <div class='modal-header'>
          <button type='button' class='close' data-dismiss='modal'>&times;</button>
          <h4 class='modal-title'>New Person</h4>
           <div id='newmessage' style='display:none;color:red;font-size:16px;'></div>
        </div>
        <div class='modal-body'>
          <!--div class='form-group'>
       <label for='new-id' class='col-sm-4 controllabel'>Person Id</label>
        <input type='text' class='form-control' id='new-id' readonly/>
      </div>-->
      <div class='form-group'>
       <label for='new-firstname' class='col-sm-4 controllabel'>First Name</label>
        <input type='text' class='form-control' id='new-firstname'/>
      </div>
      <div class='form-group'>
        <label for='new-lastname' class='col-sm-4 controllabel'>Last Name</label>
        <input type='text' class='form-control' id='new-lastname'/>
      </div>
      <div class='form-group'>
        <label for='new-dob' class='col-sm-4 controllabel'>Date of Birth</label>
        <input type='text' class='form-control' id='new-dob'/>
      </div>
       <div class='form-group'>
        <label for='new-gender' class='col-sm-4 controllabel'>Gender</label>
        <input type='text' class='form-control' id='new-gender'/>
      </div>
      <div class='form-group'>
        <label for='new-code' class='col-sm-4 controllabel'>State Code</label>
        <input type='text' class='form-control' id='new-code'/>
      </div>
        </div>
        <div class='modal-footer'>
          <button id='new-close' type='button' class='btn btn-orange' data-dismiss='modal'>Close</button>
           <button id='new-btn' type='button' class='btn btn-primary'>Save</button>
        </div>
      </div>
      
    </div>
  </div>
 </div>
";
        return html;
    }
}