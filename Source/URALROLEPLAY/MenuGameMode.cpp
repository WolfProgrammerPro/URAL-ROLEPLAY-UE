// Fill out your copyright notice in the Description page of Project Settings.

#include "MenuGameMode.h"
#include "Kismet/GameplayStatics.h"
#include "Engine/World.h"
#include "Blueprint/UserWidget.h"

AMenuGameMode::AMenuGameMode()
{
    DefaultPawnClass = nullptr;
}

void AMenuGameMode::BeginPlay()
{
    Super::BeginPlay();

    APlayerController* PC = UGameplayStatics::GetPlayerController(GetWorld(), 0);
    if (PC)
    {
        PC->bShowMouseCursor = true;
        PC->SetInputMode(FInputModeUIOnly());

        if (MenuWidgetClass)
        {
            MenuWidget = CreateWidget<UUserWidget>(PC, MenuWidgetClass);
            if (MenuWidget)
            {
                MenuWidget->AddToViewport();
            }
        }
    }
}