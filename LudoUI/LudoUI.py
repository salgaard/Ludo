import pygame
import sys

# Initialize Pygame
pygame.init()

# Set up display
WIDTH, HEIGHT = 600, 400
screen = pygame.display.set_mode((WIDTH, HEIGHT))
pygame.display.set_caption("Ludo - Start Menu")

# Colors
WHITE = (255, 255, 255)
BLACK = (0, 0, 0)
BLUE = (50, 150, 255)
GREEN = (0, 200, 0)
RED = (200, 0, 0)
YELLOW = (255, 255, 0)

# Font
font = pygame.font.Font(None, 50)

# Button class
class Button:
    def __init__(self, text, x, y, width, height, color, hover_color, action=None):
        self.text = text
        self.rect = pygame.Rect(x, y, width, height)
        self.color = color
        self.hover_color = hover_color
        self.action = action

    def draw(self, screen):
        mouse_pos = pygame.mouse.get_pos()
        color = self.hover_color if self.rect.collidepoint(mouse_pos) else self.color
        pygame.draw.rect(screen, color, self.rect)
        text_surf = font.render(self.text, True, WHITE)
        text_rect = text_surf.get_rect(center=self.rect.center)
        screen.blit(text_surf, text_rect)

    def check_click(self):
        if self.rect.collidepoint(pygame.mouse.get_pos()):
            if pygame.mouse.get_pressed()[0]:  # Left mouse click
                if self.action:
                    self.action()

# Functions for button actions
def start_game():
    print("Game Started!")  # Replace this with your Ludo game loop

def quit_game():
    pygame.quit()
    sys.exit()
    
BUTTON_WIDTH, BUTTON_HEIGHT = 200, 60
PADDING = 20  # Space between buttons

# Create buttons
play_button = Button("Play", WIDTH // 2 - BUTTON_WIDTH // 2, HEIGHT - BUTTON_HEIGHT - PADDING, BUTTON_WIDTH, BUTTON_HEIGHT, BLUE, GREEN, start_game)
quit_button = Button("Quit", 200, 250, 200, 60, RED, (255, 100, 100), quit_game)


def draw_ludo_piece(x, y, color, piece_number):
    body_height = 50
    body_width = 50
    head_radius = 15
    head_offset = 10  


    # Draw the body (cone as triangle)
    pygame.draw.polygon(screen, color, [(x - body_width // 2, y), (x + body_width // 2, y), (x, y - body_height)])

    # Draw the head (circle) **right above the triangle tip**
    pygame.draw.circle(screen, color, (x, y - body_height - head_radius + head_offset), head_radius)
    
    piece_text = font.render(str(piece_number), True, BLACK)  
    text_rect = piece_text.get_rect(center=(x, y + 30)) 
    screen.blit(piece_text, text_rect)
    

def start_menu():
    
    gameOn = True
    
    while gameOn:
        screen.fill(WHITE)
        
        # Display title
        title_text = font.render("Ludo Game", True, BLACK)
        screen.blit(title_text, (WIDTH // 2 - title_text.get_width() // 2, 50))
        
        piece_positions = [WIDTH // 5, WIDTH // 5 * 2, WIDTH // 5 * 3, WIDTH // 5 * 4]
        
        draw_ludo_piece(piece_positions[0], 180, RED, 1)  
        draw_ludo_piece(piece_positions[1], 180, BLUE, 2)  
        draw_ludo_piece(piece_positions[2], 180, GREEN, 3)  
        draw_ludo_piece(piece_positions[3], 180, YELLOW, 4)  

        # Draw buttons
        play_button.draw(screen)
        #quit_button.draw(screen)

        # Event handling
        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                gameOn = False 
                quit_game()
            elif event.type == pygame.MOUSEBUTTONDOWN:
                play_button.check_click()
                quit_button.check_click()

        pygame.display.update()

# Run the start menu
start_menu()
