﻿'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'' Author: Christopher Diekkamp
'' Email: christopher@development.diekkamp.de
'' GitHub: https://github.com/mcdikki
'' 
'' This software is licensed under the 
'' GNU General Public License Version 3 (GPLv3).
'' See http://www.gnu.org/licenses/gpl-3.0-standalone.html 
'' for a copy of the license.
''
'' You are free to copy, use and modify this software.
'' Please let know of any changes and improofments you made to it.
''
'' Thank you!
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

Imports CasparCGNETConnector

Public Interface IPlaylistItem

    Function getName() As String ' Name des Items
    Function getDelay() As Long ' Verzögerung bis zum start dieses Items in Frames
    Function getLayer() As Integer ' Layer des Items
    Function getChannel() As Integer ' Server Channel des Items
    Function isPlayable() As Boolean
    Function isLooping() As Boolean
    Function isAutoStarting() As Boolean
    Function isParallel() As Boolean


    Function getDuration() As Long ' Gesamtlaufzeit in ms
    Function getPosition() As Long ' aktuelle ms
    Function getRemaining() As Long ' noch zu spielende ms
    Function getItemType() As PlaylistItem.PlaylistItemTypes ' Typ des Item
    Function isPlaying() As Boolean
    Function isPaused() As Boolean
    Function isWaiting() As Boolean
    Function getPlayed() As Byte '% des Items gespielt
    Function getChildItems(Optional ByVal recursiv As Boolean = False) As List(Of IPlaylistItem) ' alle Items in diesem Item
    Function getPlayingChildItems(Optional ByVal recursiv As Boolean = False, Optional ByVal onlyPlayable As Boolean = False) As IEnumerable(Of IPlaylistItem) ' alle activen, spielenden Items in diesem Item
    Function getMedia() As CasparCGMedia
    Function getFPS() As Integer
    Function getController() As ServerControler
    Function getParent() As IPlaylistItem
    Function hasPlayingParent() As Boolean
    'Function getLayerUser(Optional ByVal recursiv As Boolean = False) As Dictionary(Of Integer, Integer)
    Function toXML() As String
    Function toString() As String

    Sub setParent(ByRef parent As IPlaylistItem)
    Sub setName(ByVal name As String)
    Sub setLayer(ByVal layer As Integer)
    Sub setChannel(ByVal channel As Integer)
    Sub setLooping(ByVal looping As Boolean)
    Sub setAutoStart(ByVal autoStart As Boolean)
    Sub setParallel(ByVal parallel As Boolean)
    Sub setDelay(ByVal delay As Long)
    Sub setDuration(ByVal duration As Long) ' Gesamtlaufzeit in Frames
    Sub setPosition(ByVal position As Long) ' aktuelle Frame
    Sub setRemaining(ByVal remaining As Long) ' noch zu spielende Frames
    Sub setChildItems(ByRef items As List(Of IPlaylistItem))
    Sub addItem(ByRef item As IPlaylistItem)
    Sub removeChild(ByRef child As IPlaylistItem)
    Sub insertChildAt(ByRef child As IPlaylistItem, ByRef position As IPlaylistItem)


    Sub loadXML(ByVal xml As String) ' Erstellt ein IPlaylistItem aus einer xml definition)



    Sub load() ' lädt wenn möglich item schon im Hintergrund (ACMP loadbg)
    Sub start(Optional ByVal noWait As Boolean = False)
    Sub playNextItem()
    Sub abort() ' stopt item (ACMP stop)
    Sub stoppedPlaying() ' informs item that it has stopped playing
    Sub pause(ByVal frames As Long) ' pausiert das Spielen des Items for frames Frames oder bis zum manuellen start bei 0 (ACMP pause)
    Sub unPause()

    Event waitForNext()

End Interface
