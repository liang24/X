﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Log.aspx.cs" Inherits="Pages_Log"
    Title="日志查看" MasterPageFile="~/Admin/ManagerPage.master" EnableEventValidation="false" %>

<%@ Import Namespace="NewLife.CommonEntity" %>
<asp:Content ID="Content1" ContentPlaceHolderID="C" runat="server">
    <div class="panel panel-default">
        <div class="panel-heading">日志列表</div>
        <div class="panel-body">
            <div class="form-inline">
                <div class="form-group">
                    <label for="<%=this.ddlCategory.ClientID %>" class="control-label">类别：</label>
                    <asp:DropDownList ID="ddlCategory" runat="server" AppendDataBoundItems="True"
                        DataSourceID="odsCategory" DataTextField="Category" CssClass="form-control" DataValueField="Category">
                        <asp:ListItem>全部</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="form-group">
                    <label class="control-label" for="<%=this.ddlAdmin.ClientID %>">管理员：</label>
                    <asp:DropDownList ID="ddlAdmin" runat="server" AppendDataBoundItems="True"
                        DataTextField="Name" DataValueField="ID" CssClass="form-control">
                        <asp:ListItem Value="0">全部</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="form-group">
                    <label class="control-label" for="<%=this.key.ClientID %>">关键字：</label>
                    <asp:TextBox ID="key" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="<%=this.StartDate.ClientID %>" class="control-label">时间：</label>
                    <XCL:DateTimePicker ID="StartDate" runat="server" LongTime="False" CssClass="form-control">
                    </XCL:DateTimePicker>
                </div>
                <div class="form-group">
                    <label class="control-label" for="<%=this.EndDate.ClientID %>">至</label>
                    <XCL:DateTimePicker ID="EndDate" runat="server" LongTime="False" CssClass="form-control">
                    </XCL:DateTimePicker>
                </div>
                <input name="BtnSearch" value="查询", class="btn btn-primary" />
            </div>
        </div>
        <div class="table-responsive">
            <table class="table table-bordered table-hover table-striped table-condensed">
                <thead>
                    <tr>
                        <th>序号</th>
                        <th>类别</th>
                        <th>操作</th>
                        <th>管理员</th>
                        <th>IP地址</th>
                        <th>时间</th>
                        <th>详细信息</th>
                    </tr>
                </thead>
                <tbody>
                    <%foreach (Log entity in DataList)
                      {
                    %>
                    <tr>
                        <td><%= entity.ID %></td>
                        <td><%= entity.Category %></td>
                        <td><%= entity.Action %></td>
                        <td><%= entity.UserName %></td>
                        <td><%= entity.IP %></td>
                        <td><%= entity.OccurTime %></td>
                        <td><%= entity.Remark %></td>
                    </tr>
                    <%
                      } %>
                </tbody>
            </table>
        </div>
        <div class="panel-footer">
            <p>共<span>27</span>条&nbsp;每页<span>20</span>条&nbsp;当前第<span>1</span>页/共<span>2</span>页&nbsp;<a href="#">下一页</a>&nbsp;<a href="#">尾页</a>&nbsp;转到第<input name="PageIndex" type="text" value="1" style="width:40px;text-align:right;" />页<input type="button" name="PageJump" value="GO" /></p>
        </div>
    </div>

    <div class="row-fluid">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID"
            DataSourceID="ods" AllowPaging="True" AllowSorting="True" CssClass="table table-hover"
            CellPadding="0" CellSpacing="1" GridLines="None" PageSize="20" EnableModelValidation="True">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="序号" InsertVisible="False" ReadOnly="True"
                    SortExpression="ID">
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="60px" />
                </asp:BoundField>
                <asp:BoundField DataField="Category" HeaderText="类别" SortExpression="Category" />
                <asp:BoundField DataField="Action" HeaderText="操作" SortExpression="Action" />
                <asp:BoundField DataField="UserName" HeaderText="管理员" SortExpression="UserName">
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="80px" />
                </asp:BoundField>
                <asp:BoundField DataField="IP" HeaderText="IP地址" SortExpression="IP">
                    <ItemStyle VerticalAlign="Middle" Width="100px" />
                </asp:BoundField>
                <asp:BoundField DataField="OccurTime" HeaderText="时间" SortExpression="OccurTime"
                    DataFormatString="{0:yyyy-MM-dd HH:mm:ss}">
                    <ItemStyle HorizontalAlign="Center" Width="150px" />
                </asp:BoundField>
                <asp:BoundField DataField="Remark" HeaderText="详细信息" SortExpression="Remark"></asp:BoundField>
            </Columns>
            <EmptyDataTemplate>
                没有符合条件的数据！
            </EmptyDataTemplate>
        </asp:GridView>
    </div>
    <asp:ObjectDataSource ID="ods" runat="server" EnablePaging="True" OldValuesParameterFormatString="original_{0}"
        SelectCountMethod="SearchCount" SelectMethod="Search" SortParameterName="orderClause"
        TypeName="">
        <SelectParameters>
            <asp:ControlParameter ControlID="key" Name="key" PropertyName="Text" Type="String" />
            <asp:ControlParameter ControlID="ddlAdmin" Name="adminid" PropertyName="SelectedValue"
                Type="Int32" />
            <asp:ControlParameter ControlID="ddlCategory" Name="category" PropertyName="SelectedValue"
                Type="String" />
            <asp:ControlParameter ControlID="StartDate" Name="start" PropertyName="Text" Type="DateTime" />
            <asp:ControlParameter ControlID="EndDate" Name="end" PropertyName="Text" Type="DateTime" />
            <asp:Parameter Name="orderClause" Type="String" />
            <asp:Parameter Name="startRowIndex" Type="Int32" DefaultValue="0" />
            <asp:Parameter Name="maximumRows" Type="Int32" DefaultValue="200000" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <asp:ObjectDataSource ID="odsCategory" runat="server" OldValuesParameterFormatString="original_{0}"
        SelectMethod="FindAllCategory" TypeName=""></asp:ObjectDataSource>
    <XCL:GridViewExtender ID="gvExt" runat="server">
    </XCL:GridViewExtender>
</asp:Content>
