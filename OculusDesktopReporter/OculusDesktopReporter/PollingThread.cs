using AmaranthineServer;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace EvergreenDesktopReporter
{
    class PollingThread
    {
        private TcpClient clientSocket;
        String myName;
        frm_Main form;
        IntPtr Handle;
        public PollingThread(frm_Main _form, String _myName, TcpClient _clientSocket, IntPtr _Handle)
        {
            clientSocket = _clientSocket;
            myName = _myName;
            form = _form;
            Handle = _Handle;
        }

        public String writeToServer(String message)
        {
            try
            {
                if (form.InvokeRequired)
                {
                    String returnValue = String.Empty;
                    form.Invoke((MethodInvoker)delegate
                    {
                        returnValue = form.writeToServer(message);
                    });
                    return returnValue;
                }
                else
                {
                    return form.writeToServer(message);
                }
            }
            catch (Exception)
            {
                Exception ex = new Exception("Write to Server failed");
                throw ex;
            }
        }

        public void displayInMainForm(String message, Boolean balloon = false)
        {
            try
            {
                if (form.InvokeRequired)
                {
                    form.Invoke((MethodInvoker)delegate
                    {
                        form.displayLine(message, balloon);
                    });
                }
                else
                {
                    form.displayLine(message, balloon);
                }
            }
            catch (Exception)
            {
            }
        }

        public string readFromServer()
        {
            String dataFromClient = String.Empty;
            try
            {
                NetworkStream networkStream = clientSocket.GetStream();
                networkStream.Flush();
                byte[] bytesFrom = new byte[(int)clientSocket.ReceiveBufferSize];
                networkStream.Read(bytesFrom, 0, (int)clientSocket.ReceiveBufferSize);
                networkStream.Flush();

                dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
            }
            catch (Exception e)
            {
                displayInMainForm("Disconnected");
                Exception ex = new Exception("Read from Server failed");
                throw ex;
            }
            return dataFromClient;
        }

        public void poll()
        {
            try
            {
                while (true)
                {
                    String returnData = readFromServer();
                    dynamic returnObject = null;
                    try
                    {
                        returnObject = JsonConvert.DeserializeObject(returnData);
                    }
                    catch (Exception ex)
                    {
                        displayInMainForm("Error in reading command from server...",true);
                        continue;
                    }
                    ReplyPayload<MessageContainer> clients = JsonConvert.DeserializeObject<ReplyPayload<MessageContainer>>(returnData);

                    int mnemonic = (int)returnObject.Action;
                    if (mnemonic == (int)Mnemonics.Actions.senddatanow)
                    {
                        foreach (MessageContainer message in clients.reply)
                        {
                            //displayInMainForm(message.username + ">" + message.message, true);
                            mnemonic = Convert.ToInt32(message.message);

                            switch (mnemonic)
                            {
                                case (int)Mnemonics.Actions.clientlist:
                                    {

                                    }
                                    break;

                                case (int)Mnemonics.Actions.volup:
                                    {
                                        Volume obj = new Volume(Handle);
                                        displayInMainForm("Increasing Volume",true);
                                        obj.increaseVolume();
                                    }
                                    break;
                                case (int)Mnemonics.Actions.voldown:
                                    {
                                        Volume obj = new Volume(Handle);
                                        displayInMainForm("Decreasing Volume", true);
                                        obj.decreaseVolume();
                                    }
                                    break;
                                case (int)Mnemonics.Actions.setVol:
                                    {
                                        Volume obj = new Volume(Handle);
                                        displayInMainForm("Setting Volume", true);
                                        obj.setVolume(Convert.ToUInt32(50));
                                    }
                                    break;
                                case (int)Mnemonics.Actions.mute:
                                    {
                                        Volume obj = new Volume(Handle);
                                        displayInMainForm("Muting Volume", true);
                                        obj.mute();
                                    }
                                    break;
                                case (int)Mnemonics.Actions.monitorOff:
                                    {
                                        DisplayMonitor1 obj = new DisplayMonitor1();
                                        displayInMainForm("Turning Monitor Off", true);
                                        obj.turnMonitorOff();
                                    }
                                    break;
                                case (int)Mnemonics.Actions.monitorOn:
                                    {
                                        DisplayMonitor1 obj = new DisplayMonitor1();
                                        displayInMainForm("Turning Monitor On", true);
                                        obj.turnMonitorOn();
                                    }
                                    break;
                                case (int)Mnemonics.Actions.heartBeat:
                                    {

                                    }
                                    break;
                                default:
                                    {
                                        displayInMainForm("Invalid input...", true);
                                    }
                                    break;
                            }
                        }
                    }
                }                
            }
            catch (Exception e)
            {
                form.displayLine("Error: " + e.Message + " Disconnecting self.", true);
                form.disconnect();
                return;
            }
        }
    }
}
