﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Strawberry.MobileApp.Pages.Main
{
	public class MainPage_View08_Data : BindableObject
	{
		// 아이디 속성
		public int Id { get => (int)GetValue(IdProperty); set => SetValue(IdProperty, value); }
		public static readonly BindableProperty IdProperty = BindableProperty.Create(nameof(Id), typeof(int), typeof(MainPage_View08_Data));

		// 멤버 아이디 속성
		public int MemberId { get => (int)GetValue(MemberIdProperty); set => SetValue(MemberIdProperty, value); }
		public static readonly BindableProperty MemberIdProperty = BindableProperty.Create(nameof(MemberId), typeof(int), typeof(MainPage_View08_Data));

		// 닉네임 속성
		public string Nickname { get => (string)GetValue(NicknameProperty); set => SetValue(NicknameProperty, value); }
		public static readonly BindableProperty NicknameProperty = BindableProperty.Create(nameof(Nickname), typeof(string), typeof(MainPage_View08_Data));

		// 프로필 이미지 속성
		public string ProfileImage { get => (string)GetValue(ProfileImageProperty); set => SetValue(ProfileImageProperty, value); }
		public static readonly BindableProperty ProfileImageProperty = BindableProperty.Create(nameof(ProfileImage), typeof(string), typeof(MainPage_View08_Data));

		// 생성 시간 속성
		public DateTime CreateTime { get => (DateTime)GetValue(CreateTimeProperty); set => SetValue(CreateTimeProperty, value); }
		public static readonly BindableProperty CreateTimeProperty = BindableProperty.Create(nameof(CreateTime), typeof(DateTime), typeof(MainPage_View08_Data));

		// 개수 속성
		public int Count { get => (int)GetValue(CountProperty); set => SetValue(CountProperty, value); }
		public static readonly BindableProperty CountProperty = BindableProperty.Create(nameof(Count), typeof(int), typeof(MainPage_View08_Data));
	}
}