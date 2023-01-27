<?xml version="1.0" encoding="UTF-8"?>
<document type="com.apple.InterfaceBuilder3.CocoaTouch.XIB" version="3.0" toolsVersion="11762" systemVersion="16D32" targetRuntime="iOS.CocoaTouch" propertyAccessControl="none" useAutolayout="YES" useTraitCollections="YES" colorMatched="YES">
    <device id="retina4_7" orientation="portrait">
        <adaptation id="fullscreen"/>
    </device>
    <dependencies>
        <deployment identifier="iOS"/>
        <plugIn identifier="com.apple.InterfaceBuilder.IBCocoaTouchPlugin" version="11757"/>
        <capability name="documents saved in the Xcode 8 format" minToolsVersion="8.0"/>
    </dependencies>
    <objects>
        <placeholder placeholderIdentifier="IBFilesOwner" id="-1" userLabel="File's Owner" customClass="HomeView">
            <connections>
                <outlet property="Button" destination="17" id="name-outlet-17"/>
                <outlet property="TextField" destination="10" id="name-outlet-10"/>
                <outlet property="view" destination="2" id="RRd-Eg-VrN"/>
            </connections>
        </placeholder>
        <placeholder placeholderIdentifier="IBFirstResponder" id="-2" customClass="UIResponder"/>
        <view contentMode="scaleToFill" id="2">
            <rect key="frame" x="0.0" y="0.0" width="375" height="667"/>
            <autoresizingMask key="autoresizingMask" flexibleMaxX="YES" flexibleMaxY="YES"/>
            <subviews>
                <button opaque="NO" contentMode="scaleToFill" contentHorizontalAlignment="center" contentVerticalAlignment="center" buttonType="roundedRect" lineBreakMode="middleTruncation" translatesAutoresizingMaskIntoConstraints="NO" id="17">
                    <rect key="frame" x="0.0" y="375.5" width="375" height="30"/>
                    <state key="normal" title="Reset">
                        <color key="titleShadowColor" white="0.5" alpha="1" colorSpace="calibratedWhite"/>
                    </state>
                </button>
                <textField opaque="NO" clipsSubviews="YES" contentMode="scaleToFill" contentHorizontalAlignment="left" contentVerticalAlignment="center" text="Text" borderStyle="roundedRect" minimumFontSize="17" translatesAutoresizingMaskIntoConstraints="NO" id="10">
                    <rect key="frame" x="0.0" y="318.5" width="375" height="30"/>
                    <fontDescription key="fontDescription" type="system" pointSize="14"/>
                    <textInputTraits key="textInputTraits"/>
                </textField>
            </subviews>
            <color key="backgroundColor" red="1" green="1" blue="1" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
            <constraints>
                <constraint firstItem="10" firstAttribute="width" secondItem="2" secondAttribute="width" id="0ng-P2-leZ"/>
                <constraint firstItem="10" firstAttribute="centerX" secondItem="2" secondAttribute="centerX" id="Dii-iO-6oi"/>
                <constraint firstItem="17" firstAttribute="height" secondItem="10" secondAttribute="height" id="MC0-QQ-sBb"/>
                <constraint firstItem="17" firstAttribute="centerX" secondItem="10" secondAttribute="centerX" id="ggV-Oc-D58"/>
                <constraint firstItem="10" firstAttribute="centerY" secondItem="2" secondAttribute="centerY" id="ocq-8T-Rlm"/>
                <constraint firstItem="17" firstAttribute="width" secondItem="10" secondAttribute="width" id="tgk-ns-1tm"/>
                <constraint firstItem="17" firstAttribute="top" secondItem="10" secondAttribute="bottom" constant="27" id="tzv-8v-wAf"/>
            </constraints>
            <point key="canvasLocation" x="25.5" y="52.5"/>
        </view>
    </objects>
</document>
