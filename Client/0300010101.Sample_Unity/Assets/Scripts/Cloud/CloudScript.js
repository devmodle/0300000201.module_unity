/** 유저 통계를 갱신한다 */
handlers.UpdateUserStatistics = function(args, context) {
	// 이벤트가 존재 할 경우
	if(context.playStreamEvent != null) {
		var oStatisticsInfoList = [];

		for(var oKey in context.playStreamEvent.StatisticsInfos) {
			oStatisticsInfoList.push({
				StatisticName: oKey, Value: context.playStreamEvent.StatisticsInfos[oKey]
			});
		}

		server.UpdatePlayerStatistics({
			PlayFabId: currentPlayerId, Statistics: oStatisticsInfoList
		});
	}
};
