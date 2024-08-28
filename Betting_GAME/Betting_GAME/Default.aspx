<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Betting_GAME.Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <title>Betting Game</title>
    <style>
        .styled-textbox {
            background-color: black;
            color: white;
            font-size: 16px;
            width: 260px;
            height: 300px;
        }
        .space {
            display: flex;
            gap: 50px;
            justify-content: center; 
        }
        .space1 {
            display: flex;
            gap: 110px;
            justify-content: center; 
        }

        .line {
            border: 1px white solid;
            padding: 50px;
        }

        .color-box {
            width: 100px;
            height: 100px;
            display: inline-block;
        }

        .red-box { background-color: red; }
        .green-box { background-color: green; }
        .blue-box { background-color: blue; }
        .yellow-box { background-color: yellow; }

        .player-selection {
            margin-top: 20px;
            display: flex;
            justify-content: center;
            gap: 50px; 
        }

        .player-selection label {
            font-size: 20px;
            color: white;
        }

        .color-circle {
            width: 15px;
            height: 15px;
            border-radius: 50%;
            display: inline-block;
            margin-right: 10px;
        }

        .color-red { background-color: red; }
        .color-blue { background-color: blue; }
        .color-green { background-color: green; }
        .color-yellow { background-color: yellow; }
    </style>
</head>
<body bgcolor="black">
    <center>
        <div class="line">
            <h2 class="line" style="color: aqua; font-size: 50px">Betting Game</h2>
            <h3 style="color: brown;">
                <asp:Label ID="a" runat="server" Text="Total Balance: "></asp:Label>
                <asp:Label ID="amount" runat="server" Text="903000"></asp:Label>
            </h3>
            <form id="form1" runat="server">
                <div class="space1">
                    <div><asp:Label ID="colorRed" runat="server" Text="Red" ForeColor="Red"></asp:Label></div>
                    <div><asp:Label ID="colorGreen" runat="server" Text="Green" ForeColor="Green"></asp:Label></div>
                    <div><asp:Label ID="colorBlue" runat="server" Text="Blue" ForeColor="Blue"></asp:Label></div>
                    <div><asp:Label ID="colorYellow" runat="server" Text="Yellow" ForeColor="Yellow"></asp:Label></div>
                </div>
                <br>
                <div class="space">
                    <div class="color-box red-box"></div>
                    <div class="color-box green-box"></div>
                    <div class="color-box blue-box"></div>
                    <div class="color-box yellow-box"></div>
                </div>
                
                <div class="player-selection">
                    <h3 style="color: pink;">
                        <asp:Label ID="t" runat="server" Text="Entry Fee (in rs): "></asp:Label>
                        <asp:Label ID="total" runat="server" Text="100"></asp:Label>
                    </h3>
                    <br>
                    <h3>
                        <label for="numPlayers">Select Number of Players:</label>
                    </h3>
                    <asp:DropDownList ID="numPlayers" runat="server" AutoPostBack="true" OnSelectedIndexChanged="numPlayers_SelectedIndexChanged">
                        <asp:ListItem Text="Select" Value="0" />
                        <asp:ListItem Text="1" Value="1" />
                        <asp:ListItem Text="2" Value="2" />
                        <asp:ListItem Text="3" Value="3" />
                        <asp:ListItem Text="4" Value="4" />
                    </asp:DropDownList>
                </div>
                
                <div class="player-selection">
                    <asp:Panel ID="player1Panel" runat="server" Visible="false">
                        <label for="player1List">Player 1:</label><br>
                        <h4 style="color: red;">
                            <asp:Label ID="p1" runat="server" Text="3000"></asp:Label>
                        </h4>
                        <br><br>
                        <div>
                            <asp:Button ID="ButtonRed1" runat="server" CssClass="color-circle" BackColor="Red" OnClick="ChangeColor" />
                            <asp:Button ID="ButtonGreen1" runat="server" CssClass="color-circle" BackColor="Green" OnClick="ChangeColor" />
                            <asp:Button ID="ButtonBlue1" runat="server" CssClass="color-circle" BackColor="Blue" OnClick="ChangeColor" />
                            <asp:Button ID="ButtonYellow1" runat="server" CssClass="color-circle" BackColor="Yellow" OnClick="ChangeColor" />
                        </div>
                        <h3 style="color: brown;">
                            <asp:Label ID="a1" runat="server" Text="Your investment: "></asp:Label>
                            <asp:Label ID="p1i" runat="server" Text="0"></asp:Label>
                        </h3>
                    </asp:Panel>

                    <asp:Panel ID="player2Panel" runat="server" Visible="false">
                        <label for="player2List">Player 2:</label><br>
                        <h4 style="color: red;">
                            <asp:Label ID="p2" runat="server" Text="1200"></asp:Label>
                        </h4>
                        <br><br>
                        <div>
                            <asp:Button ID="ButtonRed2" runat="server" CssClass="color-circle" BackColor="Red" OnClick="ChangeColor" />
                            <asp:Button ID="ButtonGreen2" runat="server" CssClass="color-circle" BackColor="Green" OnClick="ChangeColor" />
                            <asp:Button ID="ButtonBlue2" runat="server" CssClass="color-circle" BackColor="Blue" OnClick="ChangeColor" />
                            <asp:Button ID="ButtonYellow2" runat="server" CssClass="color-circle" BackColor="Yellow" OnClick="ChangeColor" />
                        </div>
                        <h3 style="color: brown;">
                            <asp:Label ID="a2" runat="server" Text="Your investment: "></asp:Label>
                            <asp:Label ID="p2i" runat="server" Text="0"></asp:Label>
                        </h3>
                    </asp:Panel>

                    <asp:Panel ID="player3Panel" runat="server" Visible="false">
                        <label for="player3List">Player 3:</label><br>
                        <h4 style="color: red;">
                            <asp:Label ID="p3" runat="server" Text="12200"></asp:Label>
                        </h4>
                        <br><br>
                        <div>
                            <asp:Button ID="ButtonRed3" runat="server" CssClass="color-circle" BackColor="Red" OnClick="ChangeColor" />
                            <asp:Button ID="ButtonGreen3" runat="server" CssClass="color-circle" BackColor="Green" OnClick="ChangeColor" />
                            <asp:Button ID="ButtonBlue3" runat="server" CssClass="color-circle" BackColor="Blue" OnClick="ChangeColor" />
                            <asp:Button ID="ButtonYellow3" runat="server" CssClass="color-circle" BackColor="Yellow" OnClick="ChangeColor" />
                        </div>
                        <h3 style="color: brown;">
                            <asp:Label ID="a3" runat="server" Text="Your investment: "></asp:Label>
                            <asp:Label ID="p3i" runat="server" Text="0"></asp:Label>
                        </h3>
                    </asp:Panel>

                    <asp:Panel ID="player4Panel" runat="server" Visible="false">
                        <label for="player4List">Player 4:</label><br>
                        <h4 style="color: red;">
                            <asp:Label ID="p4" runat="server" Text="10200"></asp:Label>
                        </h4>
                        <br><br>
                        <div>
                            <asp:Button ID="ButtonRed4" runat="server" CssClass="color-circle" BackColor="Red" OnClick="ChangeColor" />
                            <asp:Button ID="ButtonGreen4" runat="server" CssClass="color-circle" BackColor="Green" OnClick="ChangeColor" />
                            <asp:Button ID="ButtonBlue4" runat="server" CssClass="color-circle" BackColor="Blue" OnClick="ChangeColor" />
                            <asp:Button ID="ButtonYellow4" runat="server" CssClass="color-circle" BackColor="Yellow" OnClick="ChangeColor" />
                        </div>
                        <h3 style="color: brown;">
                            <asp:Label ID="a4" runat="server" Text="Your investment: "></asp:Label>
                            <asp:Label ID="p4i" runat="server" Text="0"></asp:Label>
                        </h3>
                    </asp:Panel>
                </div>

                <br>
                <h3><asp:Button ID="run_button" runat="server" Text="----Run----" OnClick="run_button_clicked" /></h3><br>
                <div id="colorBox" runat="server" class="color-box" style="display:none;"></div>
                <asp:Label ID="random_color" runat="server" Text="" Visible="false"/>
                <asp:Label ID="colorLabel" runat="server" Text=""/><br><br>
                <asp:TextBox id="output_text" runat="server" TextMode="MultiLine" CssClass="styled-textbox"/>
            </form>
        </div>
    </center>
</body>
</html>
